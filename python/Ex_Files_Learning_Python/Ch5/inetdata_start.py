# 
# Example file for retrieving data from the internet
#
import urllib.request

def main():
  webUrl = urllib.request.urlopen("http://msn.com")
  print("result code: " + str(webUrl.getcode()))
  date = webUrl.read()
  print(date)

if __name__ == "__main__":
  main()
