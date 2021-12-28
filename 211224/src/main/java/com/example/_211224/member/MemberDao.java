package com.example._211224.member;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

public class MemberDao {
    //db select
    public List<MemberDto> memberlist() {
        List<MemberDto> list = new ArrayList<>();

        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection conn = DriverManager.getConnection("jdbc:mysql://127.0.0.1:3306/aa","root","1234");

            PreparedStatement pstmt = conn.prepareStatement("insert into member (email,pwd,gender) values ('aa','bb','남')");
            pstmt.executeQuery();
        } catch (Exception e){
            e.printStackTrace();
        }

//        list.add(new MemberDto("aa@naver.com", "1234", "남자"))
//      list.add(new MemberDto("bb@naver.com", "1234", "여자"));

        return list;
    }

    //db insert
    public void memberset(MemberDto dto) {

    }
}