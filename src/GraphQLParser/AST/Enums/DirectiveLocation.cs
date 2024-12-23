using System.ComponentModel;

namespace GraphQLParser.AST;

/// <summary>
/// Directives must only be used in the locations they are declared to belong in.
/// https://graphql.github.io/graphql-spec/October2021/#sec-Type-System.Directives
/// </summary>
public enum DirectiveLocation
{
    // http://spec.graphql.org/October2021/#ExecutableDirectiveLocation

    /// <summary>Location adjacent to a query operation.</summary>
    [Description("Location adjacent to a query operation.")]
    Query,

    /// <summary>Location adjacent to a mutation operation.</summary>
    [Description("Location adjacent to a mutation operation.")]
    Mutation,

    /// <summary>Location adjacent to a subscription operation.</summary>
    [Description("Location adjacent to a subscription operation.")]
    Subscription,

    /// <summary>Location adjacent to a field.</summary>
    [Description("Location adjacent to a field.")]
    Field,

    /// <summary>Location adjacent to a fragment definition.</summary>
    [Description("Location adjacent to a fragment definition.")]
    FragmentDefinition,

    /// <summary>Location adjacent to a fragment spread.</summary>
    [Description("Location adjacent to a fragment spread.")]
    FragmentSpread,

    /// <summary>Location adjacent to an inline fragment.</summary>
    [Description("Location adjacent to an inline fragment.")]
    InlineFragment,

    /// <summary>Location adjacent to a variable definition.</summary>
    [Description("Location adjacent to a variable definition.")]
    VariableDefinition,

    // http://spec.graphql.org/October2021/#TypeSystemDirectiveLocation

    /// <summary>Location adjacent to a schema definition.</summary>
    [Description("Location adjacent to a schema definition.")]
    Schema,

    /// <summary>Location adjacent to a scalar definition.</summary>
    [Description("Location adjacent to a scalar definition.")]
    Scalar,

    /// <summary>Location adjacent to an object type definition.</summary>
    [Description("Location adjacent to an object type definition.")]
#pragma warning disable CA1720 // Identifiers should not contain type names
    Object,
#pragma warning restore CA1720

    /// <summary>Location adjacent to a field definition.</summary>
    [Description("Location adjacent to a field definition.")]
    FieldDefinition,

    /// <summary>Location adjacent to an argument definition.</summary>
    [Description("Location adjacent to an argument definition.")]
    ArgumentDefinition,

    /// <summary>Location adjacent to an interface definition.</summary>
    [Description("Location adjacent to an interface definition.")]
    Interface,

    /// <summary>Location adjacent to a union definition.</summary>
    [Description("Location adjacent to a union definition.")]
    Union,

    /// <summary>Location adjacent to an enum definition.</summary>
    [Description("Location adjacent to an enum definition")]
    Enum,

    /// <summary>Location adjacent to an enum value definition.</summary>
    [Description("Location adjacent to an enum value definition")]
    EnumValue,

    /// <summary>Location adjacent to an input object type definition.</summary>
    [Description("Location adjacent to an input object type definition.")]
    InputObject,

    /// <summary>Location adjacent to an input object field definition.</summary>
    [Description("Location adjacent to an input object field definition.")]
    InputFieldDefinition
}
