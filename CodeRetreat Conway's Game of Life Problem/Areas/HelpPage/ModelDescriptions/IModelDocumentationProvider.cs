using System;
using System.Reflection;

namespace CodeRetreat_Conway_s_Game_of_Life_Problem.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}