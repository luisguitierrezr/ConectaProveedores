namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] PI_HEADER_CECO (oauEbb200UGzoG3ex+M3pg)
///  <code>ST_b76a29481a19f994f96cb0bc4134fe6dStructure</code> that represent
/// s <code>PI_HEADER_CECO</code> <p>Description: PI_HEADER_CECO</p>
/// </summary>
// Name: PI_HEADER_CECO
public partial struct ST_b76a29481a19f994f96cb0bc4134fe6dStructure : ITypedRecord<ST_b76a29481a19f994f96cb0bc4134fe6dStructure> {
internal static readonly GlobalObjectKey IdPEDIDO = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*c_QfiX92Q02cMy5ory+0dQ");
internal static readonly GlobalObjectKey IdPROVEEDOR = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*Eva2XhaJT0WOI9yNZs+DVA");
internal static readonly GlobalObjectKey IdNUMERO_FACTURA = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*NB4Ho3hg10SqSN5zVdsg3Q");
internal static readonly GlobalObjectKey IdCARTA_PORTE = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*mtnE1kE8MU6PWVcoYyyE8g");
internal static readonly GlobalObjectKey IdTEXTO_CABECERA = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*ueBovJphhkmRQVfKM1budQ");
internal static readonly GlobalObjectKey IdUUID = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*vfvqP278aUmEYrEGlTeVFQ");
internal static readonly GlobalObjectKey IdFECHA_CONTABILIZACION = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*paTpopeiYEK75a2Nlp6YTg");
internal static readonly GlobalObjectKey IdFECHA_REGISTRO = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*5a71wKtLQEqRq_wG6SEW2Q");
internal static readonly GlobalObjectKey IdVALE_MATERIAL_SM = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*gfpg8ELdyk+TsT3shJAxlg");
internal static readonly GlobalObjectKey IdTEXTO_CABECERA_SM = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*xARjEoS3Mkiv6nS2lsyllA");

public string ssPEDIDO;

public string ssPROVEEDOR;

public string ssNUMERO_FACTURA;

public string ssCARTA_PORTE;

public string ssTEXTO_CABECERA;

public string ssUUID;

public string ssFECHA_CONTABILIZACION;

public string ssFECHA_REGISTRO;

public string ssVALE_MATERIAL_SM;

public string ssTEXTO_CABECERA_SM;


public BitArray OptimizedAttributes;

public ST_b76a29481a19f994f96cb0bc4134fe6dStructure() {
OptimizedAttributes = null;
ssPEDIDO = "";
ssPROVEEDOR = "";
ssNUMERO_FACTURA = "";
ssCARTA_PORTE = "";
ssTEXTO_CABECERA = "";
ssUUID = "";
ssFECHA_CONTABILIZACION = "";
ssFECHA_REGISTRO = "";
ssVALE_MATERIAL_SM = "";
ssTEXTO_CABECERA_SM = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssPEDIDO = r.ReadText(index++, "PI_HEADER_CECO.PEDIDO", "");
ssPROVEEDOR = r.ReadText(index++, "PI_HEADER_CECO.PROVEEDOR", "");
ssNUMERO_FACTURA = r.ReadText(index++, "PI_HEADER_CECO.NUMERO_FACTURA", "");
ssCARTA_PORTE = r.ReadText(index++, "PI_HEADER_CECO.CARTA_PORTE", "");
ssTEXTO_CABECERA = r.ReadText(index++, "PI_HEADER_CECO.TEXTO_CABECERA", "");
ssUUID = r.ReadText(index++, "PI_HEADER_CECO.UUID", "");
ssFECHA_CONTABILIZACION = r.ReadText(index++, "PI_HEADER_CECO.FECHA_CONTABILIZACION", "");
ssFECHA_REGISTRO = r.ReadText(index++, "PI_HEADER_CECO.FECHA_REGISTRO", "");
ssVALE_MATERIAL_SM = r.ReadText(index++, "PI_HEADER_CECO.VALE_MATERIAL_SM", "");
ssTEXTO_CABECERA_SM = r.ReadText(index++, "PI_HEADER_CECO.TEXTO_CABECERA_SM", "");
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(ST_b76a29481a19f994f96cb0bc4134fe6dStructure r) {
this = r;
}


public static bool operator == (ST_b76a29481a19f994f96cb0bc4134fe6dStructure a, ST_b76a29481a19f994f96cb0bc4134fe6dStructure b) {
if (a.ssPEDIDO != b.ssPEDIDO) return false;
if (a.ssPROVEEDOR != b.ssPROVEEDOR) return false;
if (a.ssNUMERO_FACTURA != b.ssNUMERO_FACTURA) return false;
if (a.ssCARTA_PORTE != b.ssCARTA_PORTE) return false;
if (a.ssTEXTO_CABECERA != b.ssTEXTO_CABECERA) return false;
if (a.ssUUID != b.ssUUID) return false;
if (a.ssFECHA_CONTABILIZACION != b.ssFECHA_CONTABILIZACION) return false;
if (a.ssFECHA_REGISTRO != b.ssFECHA_REGISTRO) return false;
if (a.ssVALE_MATERIAL_SM != b.ssVALE_MATERIAL_SM) return false;
if (a.ssTEXTO_CABECERA_SM != b.ssTEXTO_CABECERA_SM) return false;
return true;
}

public static bool operator != (ST_b76a29481a19f994f96cb0bc4134fe6dStructure a, ST_b76a29481a19f994f96cb0bc4134fe6dStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_b76a29481a19f994f96cb0bc4134fe6dStructure)) return false;
return (this == (ST_b76a29481a19f994f96cb0bc4134fe6dStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPEDIDO.GetHashCode()
 ^ ssPROVEEDOR.GetHashCode()
 ^ ssNUMERO_FACTURA.GetHashCode()
 ^ ssCARTA_PORTE.GetHashCode()
 ^ ssTEXTO_CABECERA.GetHashCode()
 ^ ssUUID.GetHashCode()
 ^ ssFECHA_CONTABILIZACION.GetHashCode()
 ^ ssFECHA_REGISTRO.GetHashCode()
 ^ ssVALE_MATERIAL_SM.GetHashCode()
 ^ ssTEXTO_CABECERA_SM.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_b76a29481a19f994f96cb0bc4134fe6dStructure Duplicate() {
ST_b76a29481a19f994f96cb0bc4134fe6dStructure t;
t.ssPEDIDO = this.ssPEDIDO;
t.ssPROVEEDOR = this.ssPROVEEDOR;
t.ssNUMERO_FACTURA = this.ssNUMERO_FACTURA;
t.ssCARTA_PORTE = this.ssCARTA_PORTE;
t.ssTEXTO_CABECERA = this.ssTEXTO_CABECERA;
t.ssUUID = this.ssUUID;
t.ssFECHA_CONTABILIZACION = this.ssFECHA_CONTABILIZACION;
t.ssFECHA_REGISTRO = this.ssFECHA_REGISTRO;
t.ssVALE_MATERIAL_SM = this.ssVALE_MATERIAL_SM;
t.ssTEXTO_CABECERA_SM = this.ssTEXTO_CABECERA_SM;
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "pedido") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PEDIDO")) variable.Value = ssPEDIDO; else variable.Optimized = true;
} else if (head == "proveedor") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PROVEEDOR")) variable.Value = ssPROVEEDOR; else variable.Optimized = true;
} else if (head == "numero_factura") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NUMERO_FACTURA")) variable.Value = ssNUMERO_FACTURA; else variable.Optimized = true;
} else if (head == "carta_porte") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CARTA_PORTE")) variable.Value = ssCARTA_PORTE; else variable.Optimized = true;
} else if (head == "texto_cabecera") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TEXTO_CABECERA")) variable.Value = ssTEXTO_CABECERA; else variable.Optimized = true;
} else if (head == "uuid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UUID")) variable.Value = ssUUID; else variable.Optimized = true;
} else if (head == "fecha_contabilizacion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FECHA_CONTABILIZACION")) variable.Value = ssFECHA_CONTABILIZACION; else variable.Optimized = true;
} else if (head == "fecha_registro") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FECHA_REGISTRO")) variable.Value = ssFECHA_REGISTRO; else variable.Optimized = true;
} else if (head == "vale_material_sm") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".VALE_MATERIAL_SM")) variable.Value = ssVALE_MATERIAL_SM; else variable.Optimized = true;
} else if (head == "texto_cabecera_sm") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TEXTO_CABECERA_SM")) variable.Value = ssTEXTO_CABECERA_SM; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdPEDIDO) {
return ssPEDIDO;
}
if (key == IdPROVEEDOR) {
return ssPROVEEDOR;
}
if (key == IdNUMERO_FACTURA) {
return ssNUMERO_FACTURA;
}
if (key == IdCARTA_PORTE) {
return ssCARTA_PORTE;
}
if (key == IdTEXTO_CABECERA) {
return ssTEXTO_CABECERA;
}
if (key == IdUUID) {
return ssUUID;
}
if (key == IdFECHA_CONTABILIZACION) {
return ssFECHA_CONTABILIZACION;
}
if (key == IdFECHA_REGISTRO) {
return ssFECHA_REGISTRO;
}
if (key == IdVALE_MATERIAL_SM) {
return ssVALE_MATERIAL_SM;
}
if (key == IdTEXTO_CABECERA_SM) {
return ssTEXTO_CABECERA_SM;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPEDIDO.Key.AsGuid) {
return ssPEDIDO;
}
if (attributeKey == IdPROVEEDOR.Key.AsGuid) {
return ssPROVEEDOR;
}
if (attributeKey == IdNUMERO_FACTURA.Key.AsGuid) {
return ssNUMERO_FACTURA;
}
if (attributeKey == IdCARTA_PORTE.Key.AsGuid) {
return ssCARTA_PORTE;
}
if (attributeKey == IdTEXTO_CABECERA.Key.AsGuid) {
return ssTEXTO_CABECERA;
}
if (attributeKey == IdUUID.Key.AsGuid) {
return ssUUID;
}
if (attributeKey == IdFECHA_CONTABILIZACION.Key.AsGuid) {
return ssFECHA_CONTABILIZACION;
}
if (attributeKey == IdFECHA_REGISTRO.Key.AsGuid) {
return ssFECHA_REGISTRO;
}
if (attributeKey == IdVALE_MATERIAL_SM.Key.AsGuid) {
return ssVALE_MATERIAL_SM;
}
if (attributeKey == IdTEXTO_CABECERA_SM.Key.AsGuid) {
return ssTEXTO_CABECERA_SM;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPEDIDO = (string) other.AttributeGet(IdPEDIDO);
ssPROVEEDOR = (string) other.AttributeGet(IdPROVEEDOR);
ssNUMERO_FACTURA = (string) other.AttributeGet(IdNUMERO_FACTURA);
ssCARTA_PORTE = (string) other.AttributeGet(IdCARTA_PORTE);
ssTEXTO_CABECERA = (string) other.AttributeGet(IdTEXTO_CABECERA);
ssUUID = (string) other.AttributeGet(IdUUID);
ssFECHA_CONTABILIZACION = (string) other.AttributeGet(IdFECHA_CONTABILIZACION);
ssFECHA_REGISTRO = (string) other.AttributeGet(IdFECHA_REGISTRO);
ssVALE_MATERIAL_SM = (string) other.AttributeGet(IdVALE_MATERIAL_SM);
ssTEXTO_CABECERA_SM = (string) other.AttributeGet(IdTEXTO_CABECERA_SM);
}
} // ST_b76a29481a19f994f96cb0bc4134fe6dStructure
/// <summary>
/// RecordList type <code>PI_HEADER_CECOList</code> that represents a record list of
///  <code>PI_HEADER_CECO</code>
/// </summary>
public partial class RL_e50ed3738a77b953713fcb41badee138 : GenericRecordList<ST_b76a29481a19f994f96cb0bc4134fe6dStructure>, IEnumerable, IEnumerator {

protected override ST_b76a29481a19f994f96cb0bc4134fe6dStructure GetElementDefaultValue() {
return new ST_b76a29481a19f994f96cb0bc4134fe6dStructure();
}

public T[] ToArray<T>(Func<ST_b76a29481a19f994f96cb0bc4134fe6dStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e50ed3738a77b953713fcb41badee138 recordList, Func<ST_b76a29481a19f994f96cb0bc4134fe6dStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e50ed3738a77b953713fcb41badee138(ST_b76a29481a19f994f96cb0bc4134fe6dStructure[] array) {
  RL_e50ed3738a77b953713fcb41badee138 result = new RL_e50ed3738a77b953713fcb41badee138();
result.InnerFromArray(array);
    return result;
}

public static RL_e50ed3738a77b953713fcb41badee138 ToList<T>(T[] array, Func <T, ST_b76a29481a19f994f96cb0bc4134fe6dStructure> converter) {
  RL_e50ed3738a77b953713fcb41badee138 result = new RL_e50ed3738a77b953713fcb41badee138();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e50ed3738a77b953713fcb41badee138 FromRestList<T>(RestList<T> restList, Func <T, ST_b76a29481a19f994f96cb0bc4134fe6dStructure> converter) {
  RL_e50ed3738a77b953713fcb41badee138 result = new RL_e50ed3738a77b953713fcb41badee138();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e50ed3738a77b953713fcb41badee138() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_b76a29481a19f994f96cb0bc4134fe6dStructure> NewList() {
return new RL_e50ed3738a77b953713fcb41badee138();
}


} // RL_e50ed3738a77b953713fcb41badee138
}

