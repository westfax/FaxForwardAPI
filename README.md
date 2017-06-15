## Welcome to the FaxForward API Documentation site


### Overview

The purpose of this document is to explain the WestFax API for customers that are interested in integrating faxing services into their current infrastructure. This document contains information regarding the different types of transports, state management, and compression used by the WestFax API. It also provides a brief description of every method available in the API and the required parameters for these methods. There is sample code and sample requests and responses at the end of the  document to aid the developer when integrating.

### Transport

The WestFax API supports four different means of transport: *REST, RPC, SOAP* and *SOAP* Object. These transports support the following formats: Multi-Part Form Data, XML or JSON, and SOAP (XML). All of these transports resolve to the same base URL:

[https://api.westfax.com/Polka.Api/](https://api.westfax.com/Polka.Api/)

Depending on the transport, this URL may look like the following

- REST
[https://api.westfax.com/Polka.Api/REST/SendFax/xml](https://api.westfax.com/Polka.Api/REST/SendFax/xml)
- RPC
[https://api.westfax.com/Polka.Api/RPC/xml](https://api.westfax.com/Polka.Api/RPC/xml)
- SOAP
[https://api.westfax.com/Polka.Api/SOAP](https://api.westfax.com/Polka.Api/SOAP)
- SOAP OBJECT
[https://api.westfax.com/Polka.Api/SOAPObj](https://api.westfax.com/Polka.Api/SOAPObj)

The transport must be included in the URL so the API understands how to process the request. Without a properly formatted URL, the request will fail.

*Transports* are similar in that the consuming application or service must make a secure HTTP connection to the WestFax API Server. Each of these transports resembles a remote procedure call as they are requesting an action to be performed by a remote service. They do have their nuances that make them convenient depending on the hardware and software platform of the consumer. Any of these transports will resolve to the same end result so it is up to the consumer to determine what fits best in their use case.

### REST

*REST (Representational State Transfer)* is the underlying concept of the World Wide Web. A RESTful Web Service generally involves a set of URLs that represent the objects (or nouns) that an individual might want to perform actions against. Each of these actions are defined by HTTP Verbs such as GET, PUT, etc. All of the methods in the WestFax RESTful interface are called via the HTTP Verb POST. The URL contains both the method and the response format. The request format is constrained to Multi-Part Form Data which makes this transport easy to use from a company’s intranet site or an internally hosted CRM package such as Sugar. If the user has access to a web server and can write HTML, they can send a fax!

### RPC

*RPC* or Remote Procedure Call is the concept of invoking a method on a remote process or system. Every transport the WestFax API uses is fashioned after RPC. In the terms of the WestFax API, RPC refers to calls made where both the request and response format are up to the user. The user can pick either XML or JSON for the request and either of these for the response. The action that the user is asking to be executed is contained inside of the request instead of the URL. The request format is determined by the body of the request, whereas the response format should be included in the URL of the request. This type of request should be simple to execute from Javascript or any modern programming language.

### SOAP

*SOAP* (Simple Object Access Protocol) defines the underlying format for SOAP Web Services. This type of transport is RPC via HTTP however it uses the SOAP Standard to provide a commonly understood request format. This transport doesn’t require an action or response format in the URL. All of this is encapsulated by the SOAP specification. This is the most convenient way for a user who is running a .NET environment to connect to WestFax and transmit faxes. This transport provides a WSDL that creates a strongly typed proxy between the customer’s environment and WestFax. To obtain a copy of the SOAP WSDL, please contact WestFax at [api@westfax.com](mailto:api@westfax.com).

### SOAP Object

The *SOAP Object* transport is very similar to the SOAP transport. Both transports use a strongly- typed proxy on the client side and a SOAP envelope to deliver the values from the client to the API. The SOAP Object transport has method stubs for every action that the API allows; however, all of these methods only take one parameter: The API Request Object (discussed below). The developer creates a new instance of this object, populates certain properties of the object (depending on the method being called), and then submits it to the API. Other than this, the SOAP Object transport handles the request identically to the SOAP transport. To obtain a copy of the SOAP Object WSDL, please contact WestFax at [api@westfax.com](mailto:api@westfax.com).


## State

The WestFax API supports stateless and stateful connections for each of the transports described above. Stateless requests to the API require a Username, Password, and often a Product ID to identify the user and map them back to internal objects for security purposes. In stateful connections, the user can call an authentication method at the beginning of the connection to establish their identity. This method will return a session token that the user can pass back to the API during their subsequent method calls. When calling authenticate, the user can specify whether or not they want the Session ID to be stored in a cookie. If a user asks for cookies, they will see the following in the header of the response:

```Set-Cookie: ASP.NET_SessionId=KQroCTeXzk65vsUylajktw; path=/```

If the web client being used handles cookies automatically, the user can continue to execute methods in the API without manually passing credentials or a session token. If the user opts to manage the session token themselves, it will be returned in the body of the response. They will need to pass this token in the body of the request every time they execute a method. The examples below illustrate a call to authenticate and then what a subsequent call would look like with and without cookies (these examples are shortened for brevity).


## Compression

HTTP Connections can incorporate compression if both the server and the client support it. The WestFax API supports both gzip and deflate and will compress an outgoing stream if the client requests it. This is done by providing the following line in the header of the request:

'''Accept-Encoding: gzip, deflate''
When using SOAP and a .NET Environment, it is simple to enable compression for response data.

''' C#
ApiWebService webService = new ApiWebService();
webService.EnableDecompression = true;
'''

For REST and RPC, most clients should allow appending headers to the request stream. In that case, add the Accept-Encoding directive listed above and the response will be encoded. When reading a response from the API, always check the Content-Encoding HTTP Header to determine if the response is encoded. If there were errors during the API call, the response may not be encoded.
