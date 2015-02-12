require 'socket' # Provides TCPServer and TCPSocket classes
require 'open-uri'

# Initialize a TCPServer object that will listen
# on localhost:2345 for incoming connections.
server = TCPServer.new('188.166.34.53', 1111)
number = 0
puts "RUBY SERVER FROM BERLIN RUNNING"
puts "The initital number is " + number.to_s
# loop infinitely, processing one incoming
# connection at a time.
loop do

  # Wait until a client connects, then return a TCPSocket
  # that can be used in a similar fashion to other Ruby
  # I/O objects. (In fact, TCPSocket is a subclass of IO.)
  socket = server.accept

  # Read the first line of the request (the Request-Line)
  request = socket.gets
  puts request

  # Divide the number by 2
  
  temp = number / 2
  puts "the number is " + temp.to_s

  modules = temp % 2
  puts "the modules is " + modules.to_s
  if modules == 0
    proxy = open('http://api.openweathermap.org/data/2.5/find?q=Berlin,de&units=metric').read # Daxi
  else
    proxy = open('http://api.openweathermap.org/data/2.5/find?q=Berlin,de&units=metric').read #Jhohannes
  end

  response = proxy + "\n"
  # We need to include the Content-Type and Content-Length headers
  # to let the client know the size and type of data
  # contained in the response. Note that HTTP is whitespace
  # sensitive, and expects each header line to end with CRLF (i.e. "\r\n")
  socket.print "HTTP/1.1 200 OK\r\n" +
               "Content-Type: text/plain\r\n" +
               "Content-Length: #{response.bytesize}\r\n" +
               "Connection: close\r\n"

  # Print a blank line to separate the header from the response body,
  # as required by the protocol.
  socket.print "\r\n"

  # Print the actual response body, which is just "Hello World!\n"
  socket.print response
  number = number + 1
  puts "------------------------" + number.to_s
  # Close the socket, terminating the connection
  socket.close
end
