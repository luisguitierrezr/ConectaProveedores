using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EntryOrderRequestUpdate
public class RESTST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure : AbstractRESTStructure<ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure> {
[JsonProperty("MovementClass")]
public string AttrMovementClass;

[JsonProperty("OrderNumber")]
public string AttrOrderNumber;

[JsonProperty("EntryNumber")]
public string AttrEntryNumber;

[JsonProperty("SupplierNumber")]
public string AttrSupplierNumber;

[JsonProperty("UUID")]
public string AttrUUID;

[JsonProperty("EntryNumberEM")]
public string AttrEntryNumberEM;

[JsonProperty("EntryYearEM")]
public string AttrEntryYearEM;

[JsonProperty("ReferenceEM")]
public string AttrReferenceEM;

[JsonProperty("Rows")]
public RestList<ssConectaProveedores.RestRecords.RESTST_3fd667dc2513888f6027df59e05def3fStructure> AttrRows;

public RESTST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure() { }

public RESTST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure (ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMovementClass = ConvertToRestWithoutDefaults(s.ssMovementClass, "");
AttrOrderNumber = ConvertToRestWithoutDefaults(s.ssOrderNumber, "");
AttrEntryNumber = ConvertToRestWithoutDefaults(s.ssEntryNumber, "");
AttrSupplierNumber = ConvertToRestWithoutDefaults(s.ssSupplierNumber, "");
AttrUUID = ConvertToRestWithoutDefaults(s.ssUUID, "");
AttrEntryNumberEM = ConvertToRestWithoutDefaults(s.ssEntryNumberEM, "");
AttrEntryYearEM = ConvertToRestWithoutDefaults(s.ssEntryYearEM, "");
AttrReferenceEM = ConvertToRestWithoutDefaults(s.ssReferenceEM, "");
AttrRows = s.ssRows.Length == 0 ? null : s.ssRows.ToRestList<ssConectaProveedores.RestRecords.RESTST_3fd667dc2513888f6027df59e05def3fStructure>(ssConectaProveedores.RestRecords.RESTST_3fd667dc2513888f6027df59e05def3fStructure.FromStructureDelegate(config));
  } else {
AttrMovementClass = s.ssMovementClass;
AttrOrderNumber = s.ssOrderNumber;
AttrEntryNumber = s.ssEntryNumber;
AttrSupplierNumber = s.ssSupplierNumber;
AttrUUID = s.ssUUID;
AttrEntryNumberEM = s.ssEntryNumberEM;
AttrEntryYearEM = s.ssEntryYearEM;
AttrReferenceEM = s.ssReferenceEM;
AttrRows = s.ssRows.ToRestList<ssConectaProveedores.RestRecords.RESTST_3fd667dc2513888f6027df59e05def3fStructure>(ssConectaProveedores.RestRecords.RESTST_3fd667dc2513888f6027df59e05def3fStructure.FromStructureDelegate(config));
  }
}

public static ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure obj) { 
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
  s.ssRows = RL_800c0b51440fd41c56528d60815ca788.FromRestList(obj.AttrRows, ssConectaProveedores.RestRecords.RESTST_3fd667dc2513888f6027df59e05def3fStructure.ToStructure);
  }
  return s;
}

public static Func<ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure, ssConectaProveedores.RestRecords.RESTST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure FromStructure(ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure(s, config);
}

}


