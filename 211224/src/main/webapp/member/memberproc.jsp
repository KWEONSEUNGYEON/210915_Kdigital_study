<%@ page import="com.example._211224.member.MemberDto" %>
<%@ page import="com.example._211224.member.MemberDao" %>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%
//    String email = request.getParameter("email");
//   MemberDto dto = new MemberDto(email,pwd, gender);
%>

<jsp:useBean id="dto" class="com.example._211224.member.MemberDto">
</jsp:useBean>
<jsp:setProperty name="dto" property="*"></jsp:setProperty>

<%=dto%>

<%
    // db 저장 로직
    MemberDao dao = new MemberDao();
    dao.memberset(dto);
%>
