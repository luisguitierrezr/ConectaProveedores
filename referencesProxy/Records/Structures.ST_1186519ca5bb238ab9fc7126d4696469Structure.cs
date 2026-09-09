namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] PI_HEADER_EM (tMlitVpq20G3kPa20WJa9Q)
///  <code>ST_1186519ca5bb238ab9fc7126d4696469Structure</code> that represents <code>PI_HEADER_EM</code
/// > <p>Description: PI_HEADER_EM</p>
/// </summary>
// Name: PI_HEADER_EM
public partial struct ST_1186519ca5bb238ab9fc7126d4696469Structure : ITypedRecord<ST_1186519ca5bb238ab9fc7126d4696469Structure> {
internal static readonly GlobalObjectKey IdPEDIDO = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*aSI_Xym3M0a2qBCTT6Tdbw");
internal static readonly GlobalObjectKey IdPROVEEDOR = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*MmfAhqGwTk+D9GefjttkoQ");
internal static readonly GlobalObjectKey IdNUMERO_FACTURA = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*G_Jk_KiYSU6kJzHCm6QiHw");
internal static readonly GlobalObjectKey IdCARTA_PORTE = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*Tr4bCVzM4EurVZQnrgWGmA");
internal static readonly GlobalObjectKey IdTEXTO_CABECERA = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*Y+rfS1uWZEWoTTPXzgPOfw");
internal static readonly GlobalObjectKey IdUUID = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*aidcu7mydkKU7fx_D4hYaQ");
internal static readonly GlobalObjectKey IdFECHA_CONTABILIZACION = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*IceKPypVN0OEEaK_qnEcQQ");
internal static readonly GlobalObjectKey IdFECHA_REGISTRO = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*X_KcvK2bq0+U9feoV3TXgw");

public string ssPEDIDO;

public string ssPROVEEDOR;

public string ssNUMERO_FACTURA;

public string ssCARTA_PORTE;

public string ssTEXTO_CABECERA;

public string ssUUID;

public string ssFECHA_CONTABILIZACION;

public string ssFECHA_REGISTRO;


public BitArray OptimizedAttributes;

public ST_1186519ca5bb238ab9fc7126d4696469Structure() {
OptimizedAttributes = null;
ssPEDIDO = "";
ssPROVEEDOR = "";
ssNUMERO_FACTURA = "";
ssCARTA_PORTE = "";
ssTEXTO_CABECERA = "";
ssUUID = "";
ssFECHA_CONTABILIZACION = "";
ssFECHA_REGISTRO = "";
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
ssPEDIDO = r.ReadText(index++, "PI_HEADER_EM.PEDIDO", "");
ssPROVEEDOR = r.ReadText(index++, "PI_HEADER_EM.PROVEEDOR", "");
ssNUMERO_FACTURA = r.ReadText(index++, "PI_HEADER_EM.NUMERO_FACTURA", "");
ssCARTA_PORTE = r.ReadText(index++, "PI_HEADER_EM.CARTA_PORTE", "");
ssTEXTO_CABECERA = r.ReadText(index++, "PI_HEADER_EM.TEXTO_CABECERA", "");
ssUUID = r.ReadText(index++, "PI_HEADER_EM.UUID", "");
ssFECHA_CONTABILIZACION = r.ReadText(index++, "PI_HEADER_EM.FECHA_CONTABILIZACION", "");
ssFECHA_REGISTRO = r.ReadText(index++, "PI_HEADER_EM.FECHA_REGISTRO", "");
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
public void ReadIM(ST_1186519ca5bb238ab9fc7126d4696469Structure r) {
this = r;
}


public static bool operator == (ST_1186519ca5bb238ab9fc7126d4696469Structure a, ST_1186519ca5bb238ab9fc7126d4696469Structure b) {
if (a.ssPEDIDO != b.ssPEDIDO) return false;
if (a.ssPROVEEDOR != b.ssPROVEEDOR) return false;
if (a.ssNUMERO_FACTURA != b.ssNUMERO_FACTURA) return false;
if (a.ssCARTA_PORTE != b.ssCARTA_PORTE) return false;
if (a.ssTEXTO_CABECERA != b.ssTEXTO_CABECERA) return false;
if (a.ssUUID != b.ssUUID) return false;
if (a.ssFECHA_CONTABILIZACION != b.ssFECHA_CONTABILIZACION) return false;
if (a.ssFECHA_REGISTRO != b.ssFECHA_REGISTRO) return false;
return true;
}

public static bool operator != (ST_1186519ca5bb238ab9fc7126d4696469Structure a, ST_1186519ca5bb238ab9fc7126d4696469Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_1186519ca5bb238ab9fc7126d4696469Structure)) return false;
return (this == (ST_1186519ca5bb238ab9fc7126d4696469Structure)o);
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
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_1186519ca5bb238ab9fc7126d4696469Structure Duplicate() {
ST_1186519ca5bb238ab9fc7126d4696469Structure t;
t.ssPEDIDO = this.ssPEDIDO;
t.ssPROVEEDOR = this.ssPROVEEDOR;
t.ssNUMERO_FACTURA = this.ssNUMERO_FACTURA;
t.ssCARTA_PORTE = this.ssCARTA_PORTE;
t.ssTEXTO_CABECERA = this.ssTEXTO_CABECERA;
t.ssUUID = this.ssUUID;
t.ssFECHA_CONTABILIZACION = this.ssFECHA_CONTABILIZACION;
t.ssFECHA_REGISTRO = this.ssFECHA_REGISTRO;
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
}
} // ST_1186519ca5bb238ab9fc7126d4696469Structure
/// <summary>
/// RecordList type <code>PI_HEADER_EMList</code> that represents a record list of
///  <code>PI_HEADER_EM</code>
/// </summary>
public partial class RL_6b28c379fa0c7c481b31f58824c50eb1 : GenericRecordList<ST_1186519ca5bb238ab9fc7126d4696469Structure>, IEnumerable, IEnumerator {

protected override ST_1186519ca5bb238ab9fc7126d4696469Structure GetElementDefaultValue() {
return new ST_1186519ca5bb238ab9fc7126d4696469Structure();
}

public T[] ToArray<T>(Func<ST_1186519ca5bb238ab9fc7126d4696469Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6b28c379fa0c7c481b31f58824c50eb1 recordList, Func<ST_1186519ca5bb238ab9fc7126d4696469Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6b28c379fa0c7c481b31f58824c50eb1(ST_1186519ca5bb238ab9fc7126d4696469Structure[] array) {
  RL_6b28c379fa0c7c481b31f58824c50eb1 result = new RL_6b28c379fa0c7c481b31f58824c50eb1();
result.InnerFromArray(array);
    return result;
}

public static RL_6b28c379fa0c7c481b31f58824c50eb1 ToList<T>(T[] array, Func <T, ST_1186519ca5bb238ab9fc7126d4696469Structure> converter) {
  RL_6b28c379fa0c7c481b31f58824c50eb1 result = new RL_6b28c379fa0c7c481b31f58824c50eb1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6b28c379fa0c7c481b31f58824c50eb1 FromRestList<T>(RestList<T> restList, Func <T, ST_1186519ca5bb238ab9fc7126d4696469Structure> converter) {
  RL_6b28c379fa0c7c481b31f58824c50eb1 result = new RL_6b28c379fa0c7c481b31f58824c50eb1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6b28c379fa0c7c481b31f58824c50eb1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_1186519ca5bb238ab9fc7126d4696469Structure> NewList() {
return new RL_6b28c379fa0c7c481b31f58824c50eb1();
}


} // RL_6b28c379fa0c7c481b31f58824c50eb1
}

