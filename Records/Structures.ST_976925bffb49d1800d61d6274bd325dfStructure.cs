namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] PI_HEADER5 (3uaBH7ieVkydyI76fhnkaA)
///  <code>ST_976925bffb49d1800d61d6274bd325dfStructure</code> that represents <code>PI_HEADER5</code
/// > <p>Description: </p>
/// </summary>
// Name: PI_HEADER5
public partial struct ST_976925bffb49d1800d61d6274bd325dfStructure : ITypedRecord<ST_976925bffb49d1800d61d6274bd325dfStructure> {
internal static readonly GlobalObjectKey IdPEDIDO = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*Jzzl8uJbhUmcaPQQJrQD1A");
internal static readonly GlobalObjectKey IdPROVEEDOR = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*Jw2pgP_60E+z9mJacxPkEA");
internal static readonly GlobalObjectKey IdNUMERO_FACTURA = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*guPL+FKsxEKN4MgK10lyTw");
internal static readonly GlobalObjectKey IdCARTA_PORTE = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*CHguPjtLq0yi30MEwYH3Qg");
internal static readonly GlobalObjectKey IdTEXTO_CABECERA = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*Cttgmu4nOEelJeDRROUEGA");
internal static readonly GlobalObjectKey IdUUID = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*z11Y1B1vSEmHOOZ4WPRAqQ");
internal static readonly GlobalObjectKey IdFECHA_CONTABILIZACION = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*naG5L54e2U2sCka3cG20oQ");
internal static readonly GlobalObjectKey IdFECHA_REGISTRO = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*XtTGFMbR_UO45mtIxQQIJg");
internal static readonly GlobalObjectKey IdVALE_MATERIAL_SM = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*yr_oGctN+kSIlrWGp6ByKA");
internal static readonly GlobalObjectKey IdTEXTO_CABECERA_SM = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*RiQMu1D7dUOr71VvYCVsLA");

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

public ST_976925bffb49d1800d61d6274bd325dfStructure() {
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
ssPEDIDO = r.ReadText(index++, "PI_HEADER5.PEDIDO", "");
ssPROVEEDOR = r.ReadText(index++, "PI_HEADER5.PROVEEDOR", "");
ssNUMERO_FACTURA = r.ReadText(index++, "PI_HEADER5.NUMERO_FACTURA", "");
ssCARTA_PORTE = r.ReadText(index++, "PI_HEADER5.CARTA_PORTE", "");
ssTEXTO_CABECERA = r.ReadText(index++, "PI_HEADER5.TEXTO_CABECERA", "");
ssUUID = r.ReadText(index++, "PI_HEADER5.UUID", "");
ssFECHA_CONTABILIZACION = r.ReadText(index++, "PI_HEADER5.FECHA_CONTABILIZACION", "");
ssFECHA_REGISTRO = r.ReadText(index++, "PI_HEADER5.FECHA_REGISTRO", "");
ssVALE_MATERIAL_SM = r.ReadText(index++, "PI_HEADER5.VALE_MATERIAL_SM", "");
ssTEXTO_CABECERA_SM = r.ReadText(index++, "PI_HEADER5.TEXTO_CABECERA_SM", "");
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
public void ReadIM(ST_976925bffb49d1800d61d6274bd325dfStructure r) {
this = r;
}


public static bool operator == (ST_976925bffb49d1800d61d6274bd325dfStructure a, ST_976925bffb49d1800d61d6274bd325dfStructure b) {
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

public static bool operator != (ST_976925bffb49d1800d61d6274bd325dfStructure a, ST_976925bffb49d1800d61d6274bd325dfStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_976925bffb49d1800d61d6274bd325dfStructure)) return false;
return (this == (ST_976925bffb49d1800d61d6274bd325dfStructure)o);
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


public ST_976925bffb49d1800d61d6274bd325dfStructure Duplicate() {
ST_976925bffb49d1800d61d6274bd325dfStructure t;
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
} // ST_976925bffb49d1800d61d6274bd325dfStructure
/// <summary>
/// RecordList type <code>PI_HEADER5List</code> that represents a record list of
///  <code>PI_HEADER5</code>
/// </summary>
public partial class RL_ae0b6549916032862747e1c174735520 : GenericRecordList<ST_976925bffb49d1800d61d6274bd325dfStructure>, IEnumerable, IEnumerator {

protected override ST_976925bffb49d1800d61d6274bd325dfStructure GetElementDefaultValue() {
return new ST_976925bffb49d1800d61d6274bd325dfStructure();
}

public T[] ToArray<T>(Func<ST_976925bffb49d1800d61d6274bd325dfStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ae0b6549916032862747e1c174735520 recordList, Func<ST_976925bffb49d1800d61d6274bd325dfStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ae0b6549916032862747e1c174735520(ST_976925bffb49d1800d61d6274bd325dfStructure[] array) {
  RL_ae0b6549916032862747e1c174735520 result = new RL_ae0b6549916032862747e1c174735520();
result.InnerFromArray(array);
    return result;
}

public static RL_ae0b6549916032862747e1c174735520 ToList<T>(T[] array, Func <T, ST_976925bffb49d1800d61d6274bd325dfStructure> converter) {
  RL_ae0b6549916032862747e1c174735520 result = new RL_ae0b6549916032862747e1c174735520();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ae0b6549916032862747e1c174735520 FromRestList<T>(RestList<T> restList, Func <T, ST_976925bffb49d1800d61d6274bd325dfStructure> converter) {
  RL_ae0b6549916032862747e1c174735520 result = new RL_ae0b6549916032862747e1c174735520();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ae0b6549916032862747e1c174735520() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_976925bffb49d1800d61d6274bd325dfStructure> NewList() {
return new RL_ae0b6549916032862747e1c174735520();
}


} // RL_ae0b6549916032862747e1c174735520
}

