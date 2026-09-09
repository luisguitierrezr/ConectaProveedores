using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Bank
public class RESTEN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord : AbstractRESTStructure<EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("Name")]
public string AttrName;

[JsonProperty("ShortName")]
public string AttrShortName;

[JsonProperty("Code")]
public string AttrCode;

[JsonProperty("IsActive")]
public bool? AttrIsActive;

[JsonProperty("Order")]
public int? AttrOrder;

public RESTEN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord() { }

public RESTEN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord (EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord obj) { 
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

public static Func<EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord, ssConectaProveedores.RestRecords.RESTEN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord FromStructure(EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord(s, config);
}

}


