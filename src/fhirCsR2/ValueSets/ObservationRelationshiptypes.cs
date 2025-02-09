// <auto-generated />
// Built from: hl7.fhir.r2.core version: 1.0.2
  // Option: "NAMESPACE" = "fhirCsR2"

using fhirCsR2.Models;

namespace fhirCsR2.ValueSets
{
  /// <summary>
  /// Codes specifying how two observations are related.
  /// </summary>
  public static class ObservationRelationshiptypesCodes
  {
    /// <summary>
    /// The target resource (Observation or QuestionnaireResponse) is part of the information from which this observation value is derived. (e.g. calculated anion gap, Apgar score)  NOTE:  "derived-from" is only logical choice when referencing QuestionnaireResponse.
    /// </summary>
    public static readonly Coding DerivedFrom = new Coding
    {
      Code = "derived-from",
      Display = "Derived From",
      System = "http://hl7.org/fhir/observation-relationshiptypes"
    };
    /// <summary>
    /// This observation is a group observation (e.g. a battery, a panel of tests, a set of vital sign measurements) that includes the target as a member of the group.
    /// </summary>
    public static readonly Coding HasMember = new Coding
    {
      Code = "has-member",
      Display = "Has Member",
      System = "http://hl7.org/fhir/observation-relationshiptypes"
    };
    /// <summary>
    /// The value of the target observation interferes (degrades quality, or prevents valid observation) with the semantics of the source observation (e.g. a hemolysis measure target from a plasma potassium measure which has no value).
    /// </summary>
    public static readonly Coding InterferedBy = new Coding
    {
      Code = "interfered-by",
      Display = "Interfered By",
      System = "http://hl7.org/fhir/observation-relationshiptypes"
    };
    /// <summary>
    /// The value of the target observation qualifies (refines) the semantics of the source observation (e.g. a lipemia measure target from a plasma measure).
    /// </summary>
    public static readonly Coding QualifiedBy = new Coding
    {
      Code = "qualified-by",
      Display = "Qualified By",
      System = "http://hl7.org/fhir/observation-relationshiptypes"
    };
    /// <summary>
    /// This observation replaces a previous observation (i.e. a revised value). The target observation is now obsolete.
    /// </summary>
    public static readonly Coding Replaces = new Coding
    {
      Code = "replaces",
      Display = "Replaces",
      System = "http://hl7.org/fhir/observation-relationshiptypes"
    };
    /// <summary>
    /// This observation follows the target observation (e.g. timed tests such as Glucose Tolerance Test).
    /// </summary>
    public static readonly Coding SequelTo = new Coding
    {
      Code = "sequel-to",
      Display = "Sequel To",
      System = "http://hl7.org/fhir/observation-relationshiptypes"
    };

    /// <summary>
    /// Literal for code: DerivedFrom
    /// </summary>
    public const string LiteralDerivedFrom = "derived-from";

    /// <summary>
    /// Literal for code: ObservationRelationshiptypesDerivedFrom
    /// </summary>
    public const string LiteralObservationRelationshiptypesDerivedFrom = "http://hl7.org/fhir/observation-relationshiptypes#derived-from";

    /// <summary>
    /// Literal for code: HasMember
    /// </summary>
    public const string LiteralHasMember = "has-member";

    /// <summary>
    /// Literal for code: ObservationRelationshiptypesHasMember
    /// </summary>
    public const string LiteralObservationRelationshiptypesHasMember = "http://hl7.org/fhir/observation-relationshiptypes#has-member";

    /// <summary>
    /// Literal for code: InterferedBy
    /// </summary>
    public const string LiteralInterferedBy = "interfered-by";

    /// <summary>
    /// Literal for code: ObservationRelationshiptypesInterferedBy
    /// </summary>
    public const string LiteralObservationRelationshiptypesInterferedBy = "http://hl7.org/fhir/observation-relationshiptypes#interfered-by";

    /// <summary>
    /// Literal for code: QualifiedBy
    /// </summary>
    public const string LiteralQualifiedBy = "qualified-by";

    /// <summary>
    /// Literal for code: ObservationRelationshiptypesQualifiedBy
    /// </summary>
    public const string LiteralObservationRelationshiptypesQualifiedBy = "http://hl7.org/fhir/observation-relationshiptypes#qualified-by";

    /// <summary>
    /// Literal for code: Replaces
    /// </summary>
    public const string LiteralReplaces = "replaces";

    /// <summary>
    /// Literal for code: ObservationRelationshiptypesReplaces
    /// </summary>
    public const string LiteralObservationRelationshiptypesReplaces = "http://hl7.org/fhir/observation-relationshiptypes#replaces";

    /// <summary>
    /// Literal for code: SequelTo
    /// </summary>
    public const string LiteralSequelTo = "sequel-to";

    /// <summary>
    /// Literal for code: ObservationRelationshiptypesSequelTo
    /// </summary>
    public const string LiteralObservationRelationshiptypesSequelTo = "http://hl7.org/fhir/observation-relationshiptypes#sequel-to";

    /// <summary>
    /// Dictionary for looking up ObservationRelationshiptypes Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "derived-from", DerivedFrom }, 
      { "http://hl7.org/fhir/observation-relationshiptypes#derived-from", DerivedFrom }, 
      { "has-member", HasMember }, 
      { "http://hl7.org/fhir/observation-relationshiptypes#has-member", HasMember }, 
      { "interfered-by", InterferedBy }, 
      { "http://hl7.org/fhir/observation-relationshiptypes#interfered-by", InterferedBy }, 
      { "qualified-by", QualifiedBy }, 
      { "http://hl7.org/fhir/observation-relationshiptypes#qualified-by", QualifiedBy }, 
      { "replaces", Replaces }, 
      { "http://hl7.org/fhir/observation-relationshiptypes#replaces", Replaces }, 
      { "sequel-to", SequelTo }, 
      { "http://hl7.org/fhir/observation-relationshiptypes#sequel-to", SequelTo }, 
    };
  };
}
