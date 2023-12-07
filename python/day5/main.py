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
        

def multi_shape():
    colors = ["red", "blue", "green", "yellow", "orange", "purple", "pink", "brown", "gray"]
    for sides in range(3, 11):
        derek_the_turtle.color(colors[sides-3])
        for _ in range(sides):
            derek_the_turtle.forward(100)
            derek_the_turtle.right(360 / sides)
                

multi_shape()

screen = Screen()
screen.exitonclick()
        
        
        

# dash_line()
