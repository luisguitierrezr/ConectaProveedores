using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Bank
public class JSONEN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord : AbstractRESTStructure<EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

[JsonProperty("ShortName")]
[JsonPropertyName("ShortName")]
public string AttrShortName;

[JsonProperty("Code")]
[JsonPropertyName("Code")]
public string AttrCode;

[JsonProperty("IsActive")]
[JsonPropertyName("IsActive")]
public bool? AttrIsActive;

[JsonProperty("Order")]
[JsonPropertyName("Order")]
public int? AttrOrder;

public JSONEN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord() { }

public JSONEN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord (EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrName = s.ssName;
AttrShortName = s.ssShortName;
AttrCode = ConvertToRestWithoutDefaults(s.ssCode, "");
AttrIsActive = ConvertToRestWithoutDefaults(s.ssIsActive, true);
AttrOrder = ConvertToRestWithoutDefaults(s.ssOrder, 0);
  } else {
AttrId = (long?) s.ssId;
AttrName = s.ssName;
AttrShortName = s.ssShortName;
AttrCode = s.ssCode;
AttrIsActive = (bool?) s.ssIsActive;
AttrOrder = (int?) s.ssOrder;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord, EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord s) => ToStructure(s, config);
}
public static EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord s = new EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssShortName = obj.AttrShortName == null ? "" : obj.AttrShortName;
  s.ssCode = obj.AttrCode == null ? "" : obj.AttrCode;
  s.ssIsActive = obj.AttrIsActive == null ? true : obj.AttrIsActive.Value;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  }
  return s;
}

public static Func<EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord, ssConectaProveedores.RestRecords.JSONEN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord FromStructure(EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord(s, config);
}

}


