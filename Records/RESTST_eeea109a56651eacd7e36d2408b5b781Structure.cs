using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderDistributionImportStruc
public class RESTST_eeea109a56651eacd7e36d2408b5b781Structure : AbstractRESTStructure<ST_eeea109a56651eacd7e36d2408b5b781Structure> {
[JsonProperty("Division")]
public string AttrDivision;

[JsonProperty("Applicant")]
public string AttrApplicant;

[JsonProperty("ApplicantDescription")]
public string AttrApplicantDescription;

[JsonProperty("Direction")]
public string AttrDirection;

[JsonProperty("FirstContact")]
public string AttrFirstContact;

[JsonProperty("SecondContact")]
public string AttrSecondContact;

[JsonProperty("FirstApprover")]
public string AttrFirstApprover;

[JsonProperty("SecondApprover")]
public string AttrSecondApprover;

public RESTST_eeea109a56651eacd7e36d2408b5b781Structure() { }

public RESTST_eeea109a56651eacd7e36d2408b5b781Structure (ST_eeea109a56651eacd7e36d2408b5b781Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDivision = ConvertToRestWithoutDefaults(s.ssDivision, "");
AttrApplicant = ConvertToRestWithoutDefaults(s.ssApplicant, "");
AttrApplicantDescription = ConvertToRestWithoutDefaults(s.ssApplicantDescription, "");
AttrDirection = ConvertToRestWithoutDefaults(s.ssDirection, "");
AttrFirstContact = ConvertToRestWithoutDefaults(s.ssFirstContact, "");
AttrSecondContact = ConvertToRestWithoutDefaults(s.ssSecondContact, "");
AttrFirstApprover = ConvertToRestWithoutDefaults(s.ssFirstApprover, "");
AttrSecondApprover = ConvertToRestWithoutDefaults(s.ssSecondApprover, "");
  } else {
AttrDivision = s.ssDivision;
AttrApplicant = s.ssApplicant;
AttrApplicantDescription = s.ssApplicantDescription;
AttrDirection = s.ssDirection;
AttrFirstContact = s.ssFirstContact;
AttrSecondContact = s.ssSecondContact;
AttrFirstApprover = s.ssFirstApprover;
AttrSecondApprover = s.ssSecondApprover;
  }
}

public static ST_eeea109a56651eacd7e36d2408b5b781Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_eeea109a56651eacd7e36d2408b5b781Structure obj) { 
  ST_eeea109a56651eacd7e36d2408b5b781Structure s = new ST_eeea109a56651eacd7e36d2408b5b781Structure();
  if(obj != null) {
  s.ssDivision = obj.AttrDivision == null ? "" : obj.AttrDivision;
  s.ssApplicant = obj.AttrApplicant == null ? "" : obj.AttrApplicant;
  s.ssApplicantDescription = obj.AttrApplicantDescription == null ? "" : obj.AttrApplicantDescription;
  s.ssDirection = obj.AttrDirection == null ? "" : obj.AttrDirection;
  s.ssFirstContact = obj.AttrFirstContact == null ? "" : obj.AttrFirstContact;
  s.ssSecondContact = obj.AttrSecondContact == null ? "" : obj.AttrSecondContact;
  s.ssFirstApprover = obj.AttrFirstApprover == null ? "" : obj.AttrFirstApprover;
  s.ssSecondApprover = obj.AttrSecondApprover == null ? "" : obj.AttrSecondApprover;
  }
  return s;
}

public static Func<ST_eeea109a56651eacd7e36d2408b5b781Structure, ssConectaProveedores.RestRecords.RESTST_eeea109a56651eacd7e36d2408b5b781Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_eeea109a56651eacd7e36d2408b5b781Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_eeea109a56651eacd7e36d2408b5b781Structure FromStructure(ST_eeea109a56651eacd7e36d2408b5b781Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_eeea109a56651eacd7e36d2408b5b781Structure(s, config);
}

}


