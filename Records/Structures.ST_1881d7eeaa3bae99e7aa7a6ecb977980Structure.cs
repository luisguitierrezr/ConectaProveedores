namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] TO_RESULTADO_In (xeJ1_zxwPE+wB1uNqP6LaQ)
///  <code>ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure</code> that represent
/// s <code>TO_RESULTADO_In</code> <p>Description: </p>
/// </summary>
// Name: TO_RESULTADO_In
public partial struct ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure : ITypedRecord<ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure> {
internal static readonly GlobalObjectKey IdID_POLIZA = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*qEVpPeLJoUqaj_+g+elvKw");
internal static readonly GlobalObjectKey IdCODIGO = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*QjfJwUQJXU+B51I_Uetc1w");
internal static readonly GlobalObjectKey IdTEXTO = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*sNNEE_tQtUye3L7wBqX5DA");

public string ssID_POLIZA;

public string ssCODIGO;

public string ssTEXTO;


public BitArray OptimizedAttributes;

public ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure() {
OptimizedAttributes = null;
ssID_POLIZA = "";
ssCODIGO = "";
ssTEXTO = "";
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
ssID_POLIZA = r.ReadText(index++, "TO_RESULTADO_In.ID_POLIZA", "");
ssCODIGO = r.ReadText(index++, "TO_RESULTADO_In.CODIGO", "");
ssTEXTO = r.ReadText(index++, "TO_RESULTADO_In.TEXTO", "");
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
public void ReadIM(ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure r) {
this = r;
}


public static bool operator == (ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure a, ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure b) {
if (a.ssID_POLIZA != b.ssID_POLIZA) return false;
if (a.ssCODIGO != b.ssCODIGO) return false;
if (a.ssTEXTO != b.ssTEXTO) return false;
return true;
}

public static bool operator != (ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure a, ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure)) return false;
return (this == (ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssID_POLIZA.GetHashCode()
 ^ ssCODIGO.GetHashCode()
 ^ ssTEXTO.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure Duplicate() {
ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure t;
t.ssID_POLIZA = this.ssID_POLIZA;
t.ssCODIGO = this.ssCODIGO;
t.ssTEXTO = this.ssTEXTO;
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
if (head == "id_poliza") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ID_POLIZA")) variable.Value = ssID_POLIZA; else variable.Optimized = true;
} else if (head == "codigo") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CODIGO")) variable.Value = ssCODIGO; else variable.Optimized = true;
} else if (head == "texto") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TEXTO")) variable.Value = ssTEXTO; else variable.Optimized = true;
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
if (key == IdID_POLIZA) {
return ssID_POLIZA;
}
if (key == IdCODIGO) {
return ssCODIGO;
}
if (key == IdTEXTO) {
return ssTEXTO;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdID_POLIZA.Key.AsGuid) {
return ssID_POLIZA;
}
if (attributeKey == IdCODIGO.Key.AsGuid) {
return ssCODIGO;
}
if (attributeKey == IdTEXTO.Key.AsGuid) {
return ssTEXTO;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssID_POLIZA = (string) other.AttributeGet(IdID_POLIZA);
ssCODIGO = (string) other.AttributeGet(IdCODIGO);
ssTEXTO = (string) other.AttributeGet(IdTEXTO);
}
} // ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure
/// <summary>
/// RecordList type <code>TO_RESULTADO_InList</code> that represents a record list of
///  <code>TO_RESULTADO_In</code>
/// </summary>
public partial class RL_d9182ea8cfe690c58e113da212e63df9 : GenericRecordList<ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure>, IEnumerable, IEnumerator {

protected override ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure GetElementDefaultValue() {
return new ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure();
}

public T[] ToArray<T>(Func<ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d9182ea8cfe690c58e113da212e63df9 recordList, Func<ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d9182ea8cfe690c58e113da212e63df9(ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure[] array) {
  RL_d9182ea8cfe690c58e113da212e63df9 result = new RL_d9182ea8cfe690c58e113da212e63df9();
result.InnerFromArray(array);
    return result;
}

public static RL_d9182ea8cfe690c58e113da212e63df9 ToList<T>(T[] array, Func <T, ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure> converter) {
  RL_d9182ea8cfe690c58e113da212e63df9 result = new RL_d9182ea8cfe690c58e113da212e63df9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d9182ea8cfe690c58e113da212e63df9 FromRestList<T>(RestList<T> restList, Func <T, ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure> converter) {
  RL_d9182ea8cfe690c58e113da212e63df9 result = new RL_d9182ea8cfe690c58e113da212e63df9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d9182ea8cfe690c58e113da212e63df9() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure> NewList() {
return new RL_d9182ea8cfe690c58e113da212e63df9();
}


} // RL_d9182ea8cfe690c58e113da212e63df9
}

