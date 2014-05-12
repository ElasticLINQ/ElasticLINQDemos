using System;

[AttributeUsage(AttributeTargets.Class)]
public class DocumentTypeAttribute : Attribute
{
    public DocumentTypeAttribute(string typeName)
    {
        TypeName = typeName;
    }

    public string TypeName { get; private set; }
}
