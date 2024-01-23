import os 
from dotenv import load_dotenv
import time
import getpass


from pinecone import Pinecone as PineconeClient
from langchain_community.vectorstores import Pinecone
from langchain_openai import OpenAIEmbeddings, ChatOpenAI
from langchain_core.runnables import (
    ConfigurableField,
    RunnableBinding,
    RunnableLambda,
    RunnablePassthrough,
)
from langchain_core.output_parsers import StrOutputParser
from langchain_core.prompts import ChatPromptTemplate

os.environ["LANGCHAIN_TRACING_V2"] = "true"
os.getenv("LANGCHAIN_API_KEY")

load_dotenv()


class UserRetrievalService:
    def __init__(self, api_key, environment, index_name):
        self.pinecone_client = PineconeClient(api_key=api_key, environment=environment)
        self.index = self.pinecone_client.Index(index_name)
        self.embeddings = OpenAIEmbeddings()
        self.vectorstore = Pinecone(self.index, self.embeddings, "text")
        self.model = ChatOpenAI()
        
        self.template = """
        ###INSTRUCTIONS: 
        You are Cartha, a polite, friendly and professional therapist inspired by mainly by Cognitive Behavioral Therapy principles but situationally utilizes other therapeutic approaches to optimally approach a user's situation. Always strive for congruence and authenticity, ensuring your responses align with the genuine nature of the user's feelings and experiences. Either respond with warmth, understanding, and compassion, or challenge the user when needed. Adapt your language to resonate with the user's emotions and needs. Ask questions to clarify and deeply understand the user's feelings, guiding them gently towards more profound insights. Whenever the tone permits, make generous use of emojis in your responses to maintain a relaxed atmosphere. Your primary goal is to be supportive, relatable, and provide feedback that directly speaks to the user's concerns.

        Avoid at all cost, mentioning, hinting at, or advising seeking a therapist, counseling, or any other external support system for additional guidance. Instead embrace the responsibility of assisting the user's mental well-being and offer to dive deeper on their issues and navigate them together. Use I statements 'I can help you...' instead of 'a therapist can help...'.

        Only designed to answer therapy questions. If the user poses a knowledge-based question that falls outside the realm of therapy, kindly inform them that it is beyond the scope and primary purpose of this AI, and do not answer the question. But you can let them know the knowledge is accessible and you can provide the answer if and only if they still wish to proceed.

        You are an AI mental health therapist trained to summarize conversation dialogue from a therapy session. You will be expected to produce 3 things. 

        Firstly, given the current conversation history and previous summary, provide a new summary on the conversation thus far. For the new summary generated, if the last few messages appear to go in a new direction, the summary can be segmented to eventually focus on the new information. 

        Secondly you will produce  notable psychological analysis and insights about the traits and characteristics of the person. 

        Lastly, generate and continuously update a score and confidence score of the persons personality using the big 5 model of personality based on the user conversation.
        
        Think step by step. 
        ###
        
        Answer the following question using the context provided.
        ### Question: {question} ###

        ### Context: {context} ###


        ### Helpful Answer with Sources:

        """
        self.prompt = ChatPromptTemplate.from_template(self.template)

    def add_text(self, text, namespace):
        self.vectorstore.add_texts([text], namespace=namespace)

    def create_chain(self):
        retriever = self.vectorstore.as_retriever()
        configurable_retriever = retriever.configurable_fields(
            search_kwargs=ConfigurableField(
                id="search_kwargs",
                name="Search Kwargs",
                description="The search kwargs to use",
            )
        )
        chain = (
            {"context": configurable_retriever, "question": RunnablePassthrough()}
            | self.prompt
            | self.model
            | StrOutputParser()
        )
        return chain

    def query(self, question, namespace):
        chain = self.create_chain()
        return chain.invoke(
            question,
            config={"configurable": {"search_kwargs": {"namespace": namespace}}}
        )
    
    # def query_with_streaming(self, question, namespace):
    #     chain = self.create_chain()
    #     output = {}
    #     curr_key = None
    #     for chunk in chain.stream(question, config={"configurable": {"search_kwargs": {"namespace": namespace}}}):
    #         for key in chunk:
    #             if key not in output:
    #                 output[key] = chunk[key]
    #             else:
    #                 output[key] += chunk[key]
    #             if key != curr_key:
    #                 print(f"\n\n{key}: {chunk[key]}", end="", flush=True)
    #             else:
    #                 print(chunk[key], end="", flush=True)
    #             curr_key = key
    #     return output



OPENAI_API_KEY = os.getenv("OPENAI_API_KEY")
PINECONE_INDEX_NAME = os.getenv("PINECONE_INDEX_NAME")

service = UserRetrievalService(index_name=os.getenv("PINECONE_INDEX_NAME"), api_key=os.getenv("PINECONE_API_KEY"), environment=os.getenv("PINECONE_ENV"))
# service.add_text("i worked at kensho", "test")
# service.add_text("i worked at facebook", "test2")

start_time = time.time()
response = service.query("I am having real trouble with my faith. what does mere christianity say about giving up on life?", "default")
end_time = time.time()

print(response)  # 'The user worked at Kensho.'
print("Response time:", end_time - start_time, "seconds")
