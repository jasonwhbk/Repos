# Demonstrate the use of function docstrings


def myFunction(arg1, arg2=None):
    """myFunction(arg1, arg2=None) --> Doesn't down anything
    
    Parameters:
    arg1: the first argment
    arg2: second argument

    """
    
    print(arg1, arg2)


def main():
    print(myFunction.__doc__)


if __name__ == "__main__":
    main()
