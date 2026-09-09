using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EntryOrderRequestUpdate
public class JSONST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure : AbstractRESTStructure<ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure> {
[JsonProperty("MovementClass")]
[JsonPropertyName("MovementClass")]
public string AttrMovementClass;

[JsonProperty("OrderNumber")]
[JsonPropertyName("OrderNumber")]
public string AttrOrderNumber;

[JsonProperty("EntryNumber")]
[JsonPropertyName("EntryNumber")]
public string AttrEntryNumber;

[JsonProperty("SupplierNumber")]
[JsonPropertyName("SupplierNumber")]
public string AttrSupplierNumber;

[JsonProperty("UUID")]
[JsonPropertyName("UUID")]
public string AttrUUID;

[JsonProperty("EntryNumberEM")]
[JsonPropertyName("EntryNumberEM")]
public string AttrEntryNumberEM;

[JsonProperty("EntryYearEM")]
[JsonPropertyName("EntryYearEM")]
public string AttrEntryYearEM;

[JsonProperty("ReferenceEM")]
[JsonPropertyName("ReferenceEM")]
public string AttrReferenceEM;

[JsonProperty("Rows")]
[JsonPropertyName("Rows")]
public ssConectaProveedores.RestRecords.JSONST_3fd667dc2513888f6027df59e05def3fStructure[] AttrRows;

public JSONST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure() { }

public JSONST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure (ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMovementClass = ConvertToRestWithoutDefaults(s.ssMovementClass, "");
AttrOrderNumber = ConvertToRestWithoutDefaults(s.ssOrderNumber, "");
AttrEntryNumber = ConvertToRestWithoutDefaults(s.ssEntryNumber, "");
AttrSupplierNumber = ConvertToRestWithoutDefaults(s.ssSupplierNumber, "");
AttrUUID = ConvertToRestWithoutDefaults(s.ssUUID, "");
AttrEntryNumberEM = ConvertToRestWithoutDefaults(s.ssEntryNumberEM, "");
AttrEntryYearEM = ConvertToRestWithoutDefaults(s.ssEntryYearEM, "");
AttrReferenceEM = ConvertToRestWithoutDefaults(s.ssReferenceEM, "");
AttrRows = s.ssRows.Length == 0 ? null : s.ssRows.ToArray<ssConectaProveedores.RestRecords.JSONST_3fd667dc2513888f6027df59e05def3fStructure>(ssConectaProveedores.RestRecords.JSONST_3fd667dc2513888f6027df59e05def3fStructure.FromStructureDelegate(config));
  } else {
AttrMovementClass = s.ssMovementClass;
AttrOrderNumber = s.ssOrderNumber;
AttrEntryNumber = s.ssEntryNumber;
AttrSupplierNumber = s.ssSupplierNumber;
AttrUUID = s.ssUUID;
AttrEntryNumberEM = s.ssEntryNumberEM;
AttrEntryYearEM = s.ssEntryYearEM;
AttrReferenceEM = s.ssReferenceEM;
AttrRows = s.ssRows.ToArray<ssConectaProveedores.RestRecords.JSONST_3fd667dc2513888f6027df59e05def3fStructure>(ssConectaProveedores.RestRecords.JSONST_3fd667dc2513888f6027df59e05def3fStructure.FromStructureDelegate(config));
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure, ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure s) => ToStructure(s, config);
}
public static ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure obj, IBehaviorsConfiguration config) { 
  ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure s = new ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure();
  if(obj != null) {
  s.ssMovementClass = obj.AttrMovementClass == null ? "" : obj.AttrMovementClass;
  s.ssOrderNumber = obj.AttrOrderNumber == null ? "" : obj.AttrOrderNumber;
  s.ssEntryNumber = obj.AttrEntryNumber == null ? "" : obj.AttrEntryNumber;
  s.ssSupplierNumber = obj.AttrSupplierNumber == null ? "" : obj.AttrSupplierNumber;
  s.ssUUID = obj.AttrUUID == null ? "" : obj.AttrUUID;
  s.ssEntryNumberEM = obj.AttrEntryNumberEM == null ? "" : obj.AttrEntryNumberEM;
  s.ssEntryYearEM = obj.AttrEntryYearEM == null ? "" : obj.AttrEntryYearEM;
  s.ssReferenceEM = obj.AttrReferenceEM == null ? "" : obj.AttrReferenceEM;
  s.ssRows = RL_800c0b51440fd41c56528d60815ca788.ToList(obj.AttrRows, ssConectaProveedores.RestRecords.JSONST_3fd667dc2513888f6027df59e05def3fStructure.ToStructureDelegate(config));
  }
  return s;
}

public static Func<ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure, ssConectaProveedores.RestRecords.JSONST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure FromStructure(ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure(s, config);
}

}


