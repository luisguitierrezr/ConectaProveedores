using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXMIMMF_ESTD_CUENTA_COSMOZReq
public class JSONST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure : AbstractRESTStructure<ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure> {
[JsonProperty("I_ACREEDOR")]
[JsonPropertyName("I_ACREEDOR")]
public string AttrI_ACREEDOR;

[JsonProperty("I_ANTICIPOS_HIGH")]
[JsonPropertyName("I_ANTICIPOS_HIGH")]
public string AttrI_ANTICIPOS_HIGH;

[JsonProperty("I_ANTICIPOS_LOW")]
[JsonPropertyName("I_ANTICIPOS_LOW")]
public string AttrI_ANTICIPOS_LOW;

[JsonProperty("I_F_PARTABIE")]
[JsonPropertyName("I_F_PARTABIE")]
public string AttrI_F_PARTABIE;

[JsonProperty("I_PCOMP_HIGH")]
[JsonPropertyName("I_PCOMP_HIGH")]
public string AttrI_PCOMP_HIGH;

[JsonProperty("I_PCOMP_LOW")]
[JsonPropertyName("I_PCOMP_LOW")]
public string AttrI_PCOMP_LOW;

[JsonProperty("I_REGION")]
[JsonPropertyName("I_REGION")]
public string AttrI_REGION;

[JsonProperty("I_SOCIEDAD")]
[JsonPropertyName("I_SOCIEDAD")]
public string AttrI_SOCIEDAD;

[JsonProperty("T_DAT_PROV_In")]
[JsonPropertyName("T_DAT_PROV_In")]
public ssConectaProveedores.RestRecords.JSONST_b19d23fc0038c4f52f978d3d75427ea7Structure[] AttrT_DAT_PROV_In;

[JsonProperty("T_FACT_PEN_PAG_In")]
[JsonPropertyName("T_FACT_PEN_PAG_In")]
public ssConectaProveedores.RestRecords.JSONST_0310bb62d750573571d23e0cd61c55b3Structure[] AttrT_FACT_PEN_PAG_In;

[JsonProperty("T_FAC_PAG_In")]
[JsonPropertyName("T_FAC_PAG_In")]
public ssConectaProveedores.RestRecords.JSONST_9ccb23f05cb3d8c4e4c68479ccdba9f1Structure[] AttrT_FAC_PAG_In;

[JsonProperty("T_FAC_PAG_CAB_In")]
[JsonPropertyName("T_FAC_PAG_CAB_In")]
public ssConectaProveedores.RestRecords.JSONST_828ac715d3b2e46c74367f017543eab1Structure[] AttrT_FAC_PAG_CAB_In;

public JSONST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure() { }

public JSONST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure (ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrI_ACREEDOR = s.ssI_ACREEDOR;
AttrI_ANTICIPOS_HIGH = ConvertToRestWithoutDefaults(s.ssI_ANTICIPOS_HIGH, "");
AttrI_ANTICIPOS_LOW = ConvertToRestWithoutDefaults(s.ssI_ANTICIPOS_LOW, "");
AttrI_F_PARTABIE = s.ssI_F_PARTABIE;
AttrI_PCOMP_HIGH = ConvertToRestWithoutDefaults(s.ssI_PCOMP_HIGH, "");
AttrI_PCOMP_LOW = ConvertToRestWithoutDefaults(s.ssI_PCOMP_LOW, "");
AttrI_REGION = s.ssI_REGION;
AttrI_SOCIEDAD = s.ssI_SOCIEDAD;
AttrT_DAT_PROV_In = s.ssT_DAT_PROV_In.Length == 0 ? null : s.ssT_DAT_PROV_In.ToArray<ssConectaProveedores.RestRecords.JSONST_b19d23fc0038c4f52f978d3d75427ea7Structure>(ssConectaProveedores.RestRecords.JSONST_b19d23fc0038c4f52f978d3d75427ea7Structure.FromStructureDelegate(config));
AttrT_FACT_PEN_PAG_In = s.ssT_FACT_PEN_PAG_In.Length == 0 ? null : s.ssT_FACT_PEN_PAG_In.ToArray<ssConectaProveedores.RestRecords.JSONST_0310bb62d750573571d23e0cd61c55b3Structure>(ssConectaProveedores.RestRecords.JSONST_0310bb62d750573571d23e0cd61c55b3Structure.FromStructureDelegate(config));
AttrT_FAC_PAG_In = s.ssT_FAC_PAG_In.Length == 0 ? null : s.ssT_FAC_PAG_In.ToArray<ssConectaProveedores.RestRecords.JSONST_9ccb23f05cb3d8c4e4c68479ccdba9f1Structure>(ssConectaProveedores.RestRecords.JSONST_9ccb23f05cb3d8c4e4c68479ccdba9f1Structure.FromStructureDelegate(config));
AttrT_FAC_PAG_CAB_In = s.ssT_FAC_PAG_CAB_In.Length == 0 ? null : s.ssT_FAC_PAG_CAB_In.ToArray<ssConectaProveedores.RestRecords.JSONST_828ac715d3b2e46c74367f017543eab1Structure>(ssConectaProveedores.RestRecords.JSONST_828ac715d3b2e46c74367f017543eab1Structure.FromStructureDelegate(config));
  } else {
AttrI_ACREEDOR = s.ssI_ACREEDOR;
AttrI_ANTICIPOS_HIGH = s.ssI_ANTICIPOS_HIGH;
AttrI_ANTICIPOS_LOW = s.ssI_ANTICIPOS_LOW;
AttrI_F_PARTABIE = s.ssI_F_PARTABIE;
AttrI_PCOMP_HIGH = s.ssI_PCOMP_HIGH;
AttrI_PCOMP_LOW = s.ssI_PCOMP_LOW;
AttrI_REGION = s.ssI_REGION;
AttrI_SOCIEDAD = s.ssI_SOCIEDAD;
AttrT_DAT_PROV_In = s.ssT_DAT_PROV_In.ToArray<ssConectaProveedores.RestRecords.JSONST_b19d23fc0038c4f52f978d3d75427ea7Structure>(ssConectaProveedores.RestRecords.JSONST_b19d23fc0038c4f52f978d3d75427ea7Structure.FromStructureDelegate(config));
AttrT_FACT_PEN_PAG_In = s.ssT_FACT_PEN_PAG_In.ToArray<ssConectaProveedores.RestRecords.JSONST_0310bb62d750573571d23e0cd61c55b3Structure>(ssConectaProveedores.RestRecords.JSONST_0310bb62d750573571d23e0cd61c55b3Structure.FromStructureDelegate(config));
AttrT_FAC_PAG_In = s.ssT_FAC_PAG_In.ToArray<ssConectaProveedores.RestRecords.JSONST_9ccb23f05cb3d8c4e4c68479ccdba9f1Structure>(ssConectaProveedores.RestRecords.JSONST_9ccb23f05cb3d8c4e4c68479ccdba9f1Structure.FromStructureDelegate(config));
AttrT_FAC_PAG_CAB_In = s.ssT_FAC_PAG_CAB_In.ToArray<ssConectaProveedores.RestRecords.JSONST_828ac715d3b2e46c74367f017543eab1Structure>(ssConectaProveedores.RestRecords.JSONST_828ac715d3b2e46c74367f017543eab1Structure.FromStructureDelegate(config));
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure, ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure s) => ToStructure(s, config);
}
public static ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure obj, IBehaviorsConfiguration config) { 
  ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure s = new ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure();
  if(obj != null) {
  s.ssI_ACREEDOR = obj.AttrI_ACREEDOR == null ? "" : obj.AttrI_ACREEDOR;
  s.ssI_ANTICIPOS_HIGH = obj.AttrI_ANTICIPOS_HIGH == null ? "" : obj.AttrI_ANTICIPOS_HIGH;
  s.ssI_ANTICIPOS_LOW = obj.AttrI_ANTICIPOS_LOW == null ? "" : obj.AttrI_ANTICIPOS_LOW;
  s.ssI_F_PARTABIE = obj.AttrI_F_PARTABIE == null ? "" : obj.AttrI_F_PARTABIE;
  s.ssI_PCOMP_HIGH = obj.AttrI_PCOMP_HIGH == null ? "" : obj.AttrI_PCOMP_HIGH;
  s.ssI_PCOMP_LOW = obj.AttrI_PCOMP_LOW == null ? "" : obj.AttrI_PCOMP_LOW;
  s.ssI_REGION = obj.AttrI_REGION == null ? "" : obj.AttrI_REGION;
  s.ssI_SOCIEDAD = obj.AttrI_SOCIEDAD == null ? "" : obj.AttrI_SOCIEDAD;
  s.ssT_DAT_PROV_In = RL_26f0bf6a8c3a397fae12e4e85231dc16.ToList(obj.AttrT_DAT_PROV_In, ssConectaProveedores.RestRecords.JSONST_b19d23fc0038c4f52f978d3d75427ea7Structure.ToStructureDelegate(config));
  s.ssT_FACT_PEN_PAG_In = RL_544a92ac2b1a23d422d8e47df2b48a91.ToList(obj.AttrT_FACT_PEN_PAG_In, ssConectaProveedores.RestRecords.JSONST_0310bb62d750573571d23e0cd61c55b3Structure.ToStructureDelegate(config));
  s.ssT_FAC_PAG_In = RL_152e8e5fa3664ba75db709725278e7f8.ToList(obj.AttrT_FAC_PAG_In, ssConectaProveedores.RestRecords.JSONST_9ccb23f05cb3d8c4e4c68479ccdba9f1Structure.ToStructureDelegate(config));
  s.ssT_FAC_PAG_CAB_In = RL_26adac9723b2e9519247bc502c06c341.ToList(obj.AttrT_FAC_PAG_CAB_In, ssConectaProveedores.RestRecords.JSONST_828ac715d3b2e46c74367f017543eab1Structure.ToStructureDelegate(config));
  }
  return s;
}

public static Func<ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure, ssConectaProveedores.RestRecords.JSONST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure FromStructure(ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure(s, config);
}

}


