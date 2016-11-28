

#assume ascii for simplicity
NO_OF_CHARS = 256
 
# Function to check whether two strings are anagram of
# each other
def areAnagram(str1, str2):
    if len(str1) != len(str2):
        return 0

     # Create two count arrays and initialize all values as 0
    count1 = [0] * NO_OF_CHARS
    count2 = [0] * NO_OF_CHARS
 
    # For each character in input strings, increment count
    # in the corresponding count array
    for i in str1:
        count1[ord(i)]+=1
 
    for i in str2:
        count2[ord(i)]+=1
 

    # Compare count arrays
    for i in xrange(NO_OF_CHARS):
        if count1[i] != count2[i]:
            return 0
 
    return 1