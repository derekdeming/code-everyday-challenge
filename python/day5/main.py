from turtle import Turtle, Screen

derek_the_turtle = Turtle()
derek_the_turtle.shape("turtle")
derek_the_turtle.color("red")

def square():
    for _ in range(4):
        derek_the_turtle.forward(100)
        dash_line()
        derek_the_turtle.right(90)

def dash_line():
    for _ in range(5):
        derek_the_turtle.forward(10)
        derek_the_turtle.penup()
        derek_the_turtle.forward(10)
        derek_the_turtle.pendown()

square()

screen = Screen()
screen.exitonclick()
        
        
        

# dash_line()
