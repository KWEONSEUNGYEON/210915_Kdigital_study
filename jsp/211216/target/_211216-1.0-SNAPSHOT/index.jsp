<%@ page contentType="text/html; charset=UTF-8" pageEncoding="UTF-8" %>
<!DOCTYPE html>
<html>
<head>
    <title>JSP - Hello World</title>
</head>
<body>
<%!
    public void doA() {
        System.out.println("test");
    }
%>
<%
    doA();
    doA();
%>
</h1>
<br/>
<a href="hello-servlet">Hello Servlet</a>
<a href="MyServlet">MyServlet</a>
한글나오냐..
<form action="submit.jsp" method="post">
    <input type="text" name="aa" value="한글">
    <input type="submit" value="전송">
</form>

<form action="gugudan.jsp" method="post">
    구구단<input type="text" name="gugudan"><br>
    aaa<input type="text" value="aaa"><br>
    <input type="submit" value="전송">
</form>
</body>
</html>