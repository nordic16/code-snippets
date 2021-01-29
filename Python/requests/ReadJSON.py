# This script shows how to retrieve the json from a page using the requests module.

import requests

if __name__ == '__main__':
    url = 'https://official-joke-api.appspot.com/random_joke'

    # This line retrieves the json from the response of requests.get(url).
    
    """
    In this case, the json structure looks like this:
    {
      id: value 
      type: value
      setup: value
      punchline: value
    }

    where value varies depending on the response.

    To access one of these fields, use json["fieldname"].

    For example: joke["punchline"] would retrieve the value of punchline from joke, a JSON object.
    """
    json = requests.get(url).json()
    
    print('Hey, wanna hear a joke?')

    # Prints the value of setup.
    print(f"\n{json['setup']}")

    # Prints the value of punchline
    print(f"{json['punchline']}")

