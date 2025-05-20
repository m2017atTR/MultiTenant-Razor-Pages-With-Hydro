using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace RazorTest.Conventions;
// IActionConstraint
// selector.ActionConstraints.Add(constraint);
public class TenantPageRouteModelConvention : IPageRouteModelConvention
{
    public void Apply(PageRouteModel model)
    {
        foreach (var selector in model.Selectors.ToList())
        {
            var template = selector.AttributeRouteModel.Template;

            model.Selectors.Add(new SelectorModel()
            {
                AttributeRouteModel = new AttributeRouteModel
                {
                    Template = $"{{tenantId}}/{template}"
                }
            });
        }
    }
}
