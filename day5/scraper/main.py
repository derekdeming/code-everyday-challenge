import requests
from bs4 import BeautifulSoup


url = 'https://www.secinsights.ai/conversation/10f2b96b-c1e9-4337-b735-1b446965835e'


response = requests.get(url)
if response.status_code == 200:
    soup = BeautifulSoup(response.content, 'html.parser')
    html_content = soup.prettify()
    tsx_file_path = '/Users/derekdeming/cs_projects/code-everyday-challenge/day5/scraper/html.txt'
    

    with open(tsx_file_path, 'w') as file:
        file.write("import React from 'react';\n\n")
        file.write("const YourComponent: React.FC = () => (\n")
        file.write("  <>\n")
        file.write(f"    {html_content}\n")
        file.write("  </>\n")
        file.write(");\n\n")
        file.write("export default YourComponent;\n")
else:
    print(f'Failed to retrieve the page. Status code: {response.status_code}')
