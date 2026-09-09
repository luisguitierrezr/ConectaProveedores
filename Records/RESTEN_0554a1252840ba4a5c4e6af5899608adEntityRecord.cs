using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionStatus
public class RESTEN_0554a1252840ba4a5c4e6af5899608adEntityRecord : AbstractRESTStructure<EN_0554a1252840ba4a5c4e6af5899608adEntityRecord> {
[JsonProperty("Id")]
public int? AttrId;

[JsonProperty("Label")]
public string AttrLabel;

[JsonProperty("Class")]
public string AttrClass;

[JsonProperty("Order")]
public int? AttrOrder;

[JsonProperty("Is_Active")]
public bool? AttrIs_Active;

[JsonProperty("LabelES")]
public string AttrLabelES;

public RESTEN_0554a1252840ba4a5c4e6af5899608adEntityRecord() { }

public RESTEN_0554a1252840ba4a5c4e6af5899608adEntityRecord (EN_0554a1252840ba4a5c4e6af5899608adEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (int?) s.ssId;
AttrLabel = s.ssLabel;
AttrClass = ConvertToRestWithoutDefaults(s.ssClass, "");
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
AttrLabelES = ConvertToRestWithoutDefaults(s.ssLabelES, "");
  } else {
AttrId = (int?) s.ssId;
AttrLabel = s.ssLabel;
AttrClass = s.ssClass;
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
AttrLabelES = s.ssLabelES;
  }
}

public static EN_0554a1252840ba4a5c4e6af5899608adEntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_0554a1252840ba4a5c4e6af5899608adEntityRecord obj) { 
  EN_0554a1252840ba4a5c4e6af5899608adEntityRecord s = new EN_0554a1252840ba4a5c4e6af5899608adEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssClass = obj.AttrClass == null ? "" : obj.AttrClass;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  s.ssLabelES = obj.AttrLabelES == null ? "" : obj.AttrLabelES;
  }
  return s;
}

public static Func<EN_0554a1252840ba4a5c4e6af5899608adEntityRecord, ssConectaProveedores.RestRecords.RESTEN_0554a1252840ba4a5c4e6af5899608adEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_0554a1252840ba4a5c4e6af5899608adEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_0554a1252840ba4a5c4e6af5899608adEntityRecord FromStructure(EN_0554a1252840ba4a5c4e6af5899608adEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_0554a1252840ba4a5c4e6af5899608adEntityRecord(s, config);
}

}


