from turtle import Turtle, Screen

derek_the_turtle = Turtle()
derek_the_turtle.shape("turtle")
derek_the_turtle.color("red")

def square():
    for _ in range(4):
        derek_the_turtle.forward(100)
        derek_the_turtle.right(90)
        
square()





screen = Screen()
screen.exitonclick()
