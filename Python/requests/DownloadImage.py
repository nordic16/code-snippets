import requests


# Make sure to check out the output!
if __name__ == '__main__':
    req = requests.get('https://ichef.bbci.co.uk/news/976/cpsprodpb/12A9B/production/_111434467_gettyimages-1143489763.jpg')
    
    # Just makes sure that the image was retured successfully.
    if (req):
        # Opens a stream in binary mode
        with open(r'file.png', 'wb') as file:
            file.write(req.content)
