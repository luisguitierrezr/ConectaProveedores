using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// MinuteDocumentType
public class RESTST_b2fd0f57faec93f17ef861f417f1cd5cStructure : AbstractRESTStructure<ST_b2fd0f57faec93f17ef861f417f1cd5cStructure> {
[JsonProperty("Key")]
public int? AttrKey;

[JsonProperty("Value")]
public string AttrValue;

[JsonProperty("FileName")]
public string AttrFileName;

[JsonProperty("Mandatory")]
public bool? AttrMandatory;

[JsonProperty("WithDocument")]
public bool? AttrWithDocument;

public RESTST_b2fd0f57faec93f17ef861f417f1cd5cStructure() { }

public RESTST_b2fd0f57faec93f17ef861f417f1cd5cStructure (ST_b2fd0f57faec93f17ef861f417f1cd5cStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrKey = ConvertToRestWithoutDefaults(s.ssKey, 0);
AttrValue = ConvertToRestWithoutDefaults(s.ssValue, "");
AttrFileName = ConvertToRestWithoutDefaults(s.ssFileName, "");
AttrMandatory = ConvertToRestWithoutDefaults(s.ssMandatory, false);
AttrWithDocument = ConvertToRestWithoutDefaults(s.ssWithDocument, false);
  } else {
AttrKey = (int?) s.ssKey;
AttrValue = s.ssValue;
AttrFileName = s.ssFileName;
AttrMandatory = (bool?) s.ssMandatory;
AttrWithDocument = (bool?) s.ssWithDocument;
  }
}

public static ST_b2fd0f57faec93f17ef861f417f1cd5cStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_b2fd0f57faec93f17ef861f417f1cd5cStructure obj) { 
  ST_b2fd0f57faec93f17ef861f417f1cd5cStructure s = new ST_b2fd0f57faec93f17ef861f417f1cd5cStructure();
  if(obj != null) {
  s.ssKey = obj.AttrKey == null ? 0 : obj.AttrKey.Value;
  s.ssValue = obj.AttrValue == null ? "" : obj.AttrValue;
  s.ssFileName = obj.AttrFileName == null ? "" : obj.AttrFileName;
  s.ssMandatory = obj.AttrMandatory == null ? false : obj.AttrMandatory.Value;
  s.ssWithDocument = obj.AttrWithDocument == null ? false : obj.AttrWithDocument.Value;
  }
  return s;
}

public static Func<ST_b2fd0f57faec93f17ef861f417f1cd5cStructure, ssConectaProveedores.RestRecords.RESTST_b2fd0f57faec93f17ef861f417f1cd5cStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_b2fd0f57faec93f17ef861f417f1cd5cStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_b2fd0f57faec93f17ef861f417f1cd5cStructure FromStructure(ST_b2fd0f57faec93f17ef861f417f1cd5cStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_b2fd0f57faec93f17ef861f417f1cd5cStructure(s, config);
}

}


