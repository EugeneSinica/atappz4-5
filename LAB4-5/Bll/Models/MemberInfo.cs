using System;

public class MemberInfo
{

    public int Id { get; set; }
    public int _age { get; set; }

    public String _name { get; set; }

    public String _surName { get; set; }
    public MemberInfo(String name, String surName, int age)
    {
        _name = name;
        _surName = surName;
        _age = age;

    }
}