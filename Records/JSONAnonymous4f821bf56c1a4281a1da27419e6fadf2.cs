using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PI_HEADER_CECORecord
public class JSONRC_ffd1da5bbe4de4ff46c72fbc13f0f7e2 : AbstractRESTStructure<RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2> {
[JsonProperty("PI_HEADER_CECO")]
[JsonPropertyName("PI_HEADER_CECO")]
public ssConectaProveedores.RestRecords.JSONST_b76a29481a19f994f96cb0bc4134fe6dStructure AttrPI_HEADER_CECO;

public JSONRC_ffd1da5bbe4de4ff46c72fbc13f0f7e2() { }

public JSONRC_ffd1da5bbe4de4ff46c72fbc13f0f7e2 (RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_HEADER_CECO = ConvertToRestWithoutDefaults(s.ssSTPI_HEADER_CECO, new ST_b76a29481a19f994f96cb0bc4134fe6dStructure(), ssConectaProveedores.RestRecords.JSONST_b76a29481a19f994f96cb0bc4134fe6dStructure.FromStructure, config);
  } else {
AttrPI_HEADER_CECO = ssConectaProveedores.RestRecords.JSONST_b76a29481a19f994f96cb0bc4134fe6dStructure.FromStructure(s.ssSTPI_HEADER_CECO, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_ffd1da5bbe4de4ff46c72fbc13f0f7e2, RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_ffd1da5bbe4de4ff46c72fbc13f0f7e2 s) => ToStructure(s, config);
}
public static RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2 ToStructure(ssConectaProveedores.RestRecords.JSONRC_ffd1da5bbe4de4ff46c72fbc13f0f7e2 obj, IBehaviorsConfiguration config) { 
  RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2 s = new RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2();
  if(obj != null) {
  s.ssSTPI_HEADER_CECO = ssConectaProveedores.RestRecords.JSONST_b76a29481a19f994f96cb0bc4134fe6dStructure.ToStructure(obj.AttrPI_HEADER_CECO, config);
  }
  return s;
}

public static Func<RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2, ssConectaProveedores.RestRecords.JSONRC_ffd1da5bbe4de4ff46c72fbc13f0f7e2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_ffd1da5bbe4de4ff46c72fbc13f0f7e2 FromStructure(RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_ffd1da5bbe4de4ff46c72fbc13f0f7e2(s, config);
}

}


