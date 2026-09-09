namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] BAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request (M3SQN0SmJ0exhV9uv2fUag)
///  <code>ST_0cb1a5ee06af693baf5508d00a19d139Structure</code> that represent
/// s <code>BAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request</code> <p>Description:
///  BAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request</p>
/// </summary>
// Name: BAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request
public partial struct ST_0cb1a5ee06af693baf5508d00a19d139Structure : ITypedRecord<ST_0cb1a5ee06af693baf5508d00a19d139Structure> {
internal static readonly GlobalObjectKey IdPI_BELNR = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*SY6Rz_609ka6JMCmTHkcUg");
internal static readonly GlobalObjectKey IdPI_BUKRS = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*8qcKdsNobUGYmZVC_BvUWQ");
internal static readonly GlobalObjectKey IdPI_GJAHR = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*l31ov1oGok+SH8SR5oPOTg");
internal static readonly GlobalObjectKey IdPI_ZFBDT = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*WNc5Yaw8h0eAE4tLaJJ4Dw");
internal static readonly GlobalObjectKey IdPI_ZTERM = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*6eTq3X5JY06eiGxebztuiw");

public string ssPI_BELNR;

public string ssPI_BUKRS;

public int ssPI_GJAHR;

public DateTime ssPI_ZFBDT;

public string ssPI_ZTERM;


public BitArray OptimizedAttributes;

public ST_0cb1a5ee06af693baf5508d00a19d139Structure() {
OptimizedAttributes = null;
ssPI_BELNR = "";
ssPI_BUKRS = "";
ssPI_GJAHR = 0;
ssPI_ZFBDT = (new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssPI_ZTERM = "";
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
ssPI_BELNR = r.ReadText(index++, "BAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request.PI_BELNR", "");
ssPI_BUKRS = r.ReadText(index++, "BAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request.PI_BUKRS", "");
ssPI_GJAHR = r.ReadInteger(index++, "BAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request.PI_GJAHR", 0);
ssPI_ZFBDT = r.ReadDate(index++, "BAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request.PI_ZFBDT", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssPI_ZTERM = r.ReadText(index++, "BAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request.PI_ZTERM", "");
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
public void ReadIM(ST_0cb1a5ee06af693baf5508d00a19d139Structure r) {
this = r;
}


public static bool operator == (ST_0cb1a5ee06af693baf5508d00a19d139Structure a, ST_0cb1a5ee06af693baf5508d00a19d139Structure b) {
if (a.ssPI_BELNR != b.ssPI_BELNR) return false;
if (a.ssPI_BUKRS != b.ssPI_BUKRS) return false;
if (a.ssPI_GJAHR != b.ssPI_GJAHR) return false;
if (a.ssPI_ZFBDT != b.ssPI_ZFBDT) return false;
if (a.ssPI_ZTERM != b.ssPI_ZTERM) return false;
return true;
}

public static bool operator != (ST_0cb1a5ee06af693baf5508d00a19d139Structure a, ST_0cb1a5ee06af693baf5508d00a19d139Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_0cb1a5ee06af693baf5508d00a19d139Structure)) return false;
return (this == (ST_0cb1a5ee06af693baf5508d00a19d139Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPI_BELNR.GetHashCode()
 ^ ssPI_BUKRS.GetHashCode()
 ^ ssPI_GJAHR.GetHashCode()
 ^ ssPI_ZFBDT.GetHashCode()
 ^ ssPI_ZTERM.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_0cb1a5ee06af693baf5508d00a19d139Structure Duplicate() {
ST_0cb1a5ee06af693baf5508d00a19d139Structure t;
t.ssPI_BELNR = this.ssPI_BELNR;
t.ssPI_BUKRS = this.ssPI_BUKRS;
t.ssPI_GJAHR = this.ssPI_GJAHR;
t.ssPI_ZFBDT = this.ssPI_ZFBDT;
t.ssPI_ZTERM = this.ssPI_ZTERM;
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
if (head == "pi_belnr") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_BELNR")) variable.Value = ssPI_BELNR; else variable.Optimized = true;
} else if (head == "pi_bukrs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_BUKRS")) variable.Value = ssPI_BUKRS; else variable.Optimized = true;
} else if (head == "pi_gjahr") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_GJAHR")) variable.Value = ssPI_GJAHR; else variable.Optimized = true;
} else if (head == "pi_zfbdt") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_ZFBDT")) variable.Value = ssPI_ZFBDT; else variable.Optimized = true;
} else if (head == "pi_zterm") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_ZTERM")) variable.Value = ssPI_ZTERM; else variable.Optimized = true;
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
if (key == IdPI_BELNR) {
return ssPI_BELNR;
}
if (key == IdPI_BUKRS) {
return ssPI_BUKRS;
}
if (key == IdPI_GJAHR) {
return ssPI_GJAHR;
}
if (key == IdPI_ZFBDT) {
return ssPI_ZFBDT;
}
if (key == IdPI_ZTERM) {
return ssPI_ZTERM;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPI_BELNR.Key.AsGuid) {
return ssPI_BELNR;
}
if (attributeKey == IdPI_BUKRS.Key.AsGuid) {
return ssPI_BUKRS;
}
if (attributeKey == IdPI_GJAHR.Key.AsGuid) {
return ssPI_GJAHR;
}
if (attributeKey == IdPI_ZFBDT.Key.AsGuid) {
return ssPI_ZFBDT;
}
if (attributeKey == IdPI_ZTERM.Key.AsGuid) {
return ssPI_ZTERM;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPI_BELNR = (string) other.AttributeGet(IdPI_BELNR);
ssPI_BUKRS = (string) other.AttributeGet(IdPI_BUKRS);
ssPI_GJAHR = (int) other.AttributeGet(IdPI_GJAHR);
ssPI_ZFBDT = (DateTime) other.AttributeGet(IdPI_ZFBDT);
ssPI_ZTERM = (string) other.AttributeGet(IdPI_ZTERM);
}
} // ST_0cb1a5ee06af693baf5508d00a19d139Structure
/// <summary>
/// RecordList type <code>BAPI_ZMXFFIMF_ACC_DOC_CHANGE_RequestList</code> that represents a record list
///  of <code>BAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request</code>
/// </summary>
public partial class RL_0d1911357a1f65bbff58e340864de008 : GenericRecordList<ST_0cb1a5ee06af693baf5508d00a19d139Structure>, IEnumerable, IEnumerator {

protected override ST_0cb1a5ee06af693baf5508d00a19d139Structure GetElementDefaultValue() {
return new ST_0cb1a5ee06af693baf5508d00a19d139Structure();
}

public T[] ToArray<T>(Func<ST_0cb1a5ee06af693baf5508d00a19d139Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0d1911357a1f65bbff58e340864de008 recordList, Func<ST_0cb1a5ee06af693baf5508d00a19d139Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0d1911357a1f65bbff58e340864de008(ST_0cb1a5ee06af693baf5508d00a19d139Structure[] array) {
  RL_0d1911357a1f65bbff58e340864de008 result = new RL_0d1911357a1f65bbff58e340864de008();
result.InnerFromArray(array);
    return result;
}

public static RL_0d1911357a1f65bbff58e340864de008 ToList<T>(T[] array, Func <T, ST_0cb1a5ee06af693baf5508d00a19d139Structure> converter) {
  RL_0d1911357a1f65bbff58e340864de008 result = new RL_0d1911357a1f65bbff58e340864de008();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0d1911357a1f65bbff58e340864de008 FromRestList<T>(RestList<T> restList, Func <T, ST_0cb1a5ee06af693baf5508d00a19d139Structure> converter) {
  RL_0d1911357a1f65bbff58e340864de008 result = new RL_0d1911357a1f65bbff58e340864de008();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0d1911357a1f65bbff58e340864de008() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_0cb1a5ee06af693baf5508d00a19d139Structure> NewList() {
return new RL_0d1911357a1f65bbff58e340864de008();
}


} // RL_0d1911357a1f65bbff58e340864de008
}

