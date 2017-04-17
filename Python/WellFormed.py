def CheckExpression(inputExpression):
    return False;
 
if __name__=='__main__':
    CheckExpression(['{', '(', ')', '{']) 
    CheckExpression(['{', '(', ')', '}']) 
