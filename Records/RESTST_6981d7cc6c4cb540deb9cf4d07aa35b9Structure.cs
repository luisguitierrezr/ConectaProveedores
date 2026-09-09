using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// GetErrorDistributionOutStructure
public class RESTST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure : AbstractRESTStructure<ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure> {
[JsonProperty("Division")]
public string AttrDivision;

[JsonProperty("Applicant")]
public string AttrApplicant;

[JsonProperty("ApplicantDescription")]
public string AttrApplicantDescription;

[JsonProperty("Direction")]
public string AttrDirection;

[JsonProperty("TabNumber")]
public int? AttrTabNumber;

public RESTST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure() { }

public RESTST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure (ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDivision = ConvertToRestWithoutDefaults(s.ssDivision, "");
AttrApplicant = ConvertToRestWithoutDefaults(s.ssApplicant, "");
AttrApplicantDescription = ConvertToRestWithoutDefaults(s.ssApplicantDescription, "");
AttrDirection = ConvertToRestWithoutDefaults(s.ssDirection, "");
AttrTabNumber = ConvertToRestWithoutDefaults(s.ssTabNumber, 0);
  } else {
AttrDivision = s.ssDivision;
AttrApplicant = s.ssApplicant;
AttrApplicantDescription = s.ssApplicantDescription;
AttrDirection = s.ssDirection;
AttrTabNumber = (int?) s.ssTabNumber;
  }
}

public static ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure obj) { 
  ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure s = new ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure();
  if(obj != null) {
  s.ssDivision = obj.AttrDivision == null ? "" : obj.AttrDivision;
  s.ssApplicant = obj.AttrApplicant == null ? "" : obj.AttrApplicant;
  s.ssApplicantDescription = obj.AttrApplicantDescription == null ? "" : obj.AttrApplicantDescription;
  s.ssDirection = obj.AttrDirection == null ? "" : obj.AttrDirection;
  s.ssTabNumber = obj.AttrTabNumber == null ? 0 : obj.AttrTabNumber.Value;
  }
  return s;
}

public static Func<ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure, ssConectaProveedores.RestRecords.RESTST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure FromStructure(ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure(s, config);
}

}


