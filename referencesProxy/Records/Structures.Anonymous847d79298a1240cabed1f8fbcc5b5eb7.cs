namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (KXl9hBKKykC+0fj7zFtetw)
///  <code>RC_044a5f839fa7637f6ee7b728352fd227</code> that represent
/// s <code>Z01_READ_TEXTRespRecord</code> <p>Description: </p>
/// </summary>
// Name: Z01_READ_TEXTRespRecord
public partial struct RC_044a5f839fa7637f6ee7b728352fd227 : ITypedRecord<RC_044a5f839fa7637f6ee7b728352fd227> {
internal static readonly GlobalObjectKey IdZ01_READ_TEXTResp = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*g19KBKeff2Nu57coNS_SJw");

public ST_cc99e347274d861473c4d7d08b6332b6Structure ssSTZ01_READ_TEXTResp;


public static implicit operator ST_cc99e347274d861473c4d7d08b6332b6Structure( RC_044a5f839fa7637f6ee7b728352fd227 r) {
return r.ssSTZ01_READ_TEXTResp;
}

public static implicit operator RC_044a5f839fa7637f6ee7b728352fd227 (ST_cc99e347274d861473c4d7d08b6332b6Structure r) {
RC_044a5f839fa7637f6ee7b728352fd227 res = new RC_044a5f839fa7637f6ee7b728352fd227 ();
res.ssSTZ01_READ_TEXTResp = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_044a5f839fa7637f6ee7b728352fd227() {
OptimizedAttributes = null;
ssSTZ01_READ_TEXTResp = new ST_cc99e347274d861473c4d7d08b6332b6Structure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTZ01_READ_TEXTResp.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTZ01_READ_TEXTResp.Read( r, ref index);
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
public void ReadIM(RC_044a5f839fa7637f6ee7b728352fd227 r) {
this = r;
}


public static bool operator == (RC_044a5f839fa7637f6ee7b728352fd227 a, RC_044a5f839fa7637f6ee7b728352fd227 b) {
if (a.ssSTZ01_READ_TEXTResp != b.ssSTZ01_READ_TEXTResp) return false;
return true;
}

public static bool operator != (RC_044a5f839fa7637f6ee7b728352fd227 a, RC_044a5f839fa7637f6ee7b728352fd227 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_044a5f839fa7637f6ee7b728352fd227)) return false;
return (this == (RC_044a5f839fa7637f6ee7b728352fd227)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTZ01_READ_TEXTResp.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTZ01_READ_TEXTResp.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTZ01_READ_TEXTResp.InternalRecursiveSave();
}


public RC_044a5f839fa7637f6ee7b728352fd227 Duplicate() {
RC_044a5f839fa7637f6ee7b728352fd227 t;
t.ssSTZ01_READ_TEXTResp = (ST_cc99e347274d861473c4d7d08b6332b6Structure)this.ssSTZ01_READ_TEXTResp.Duplicate();
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
if (head == "z01_read_textresp") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Z01_READ_TEXTResp")) variable.Value = ssSTZ01_READ_TEXTResp; else variable.Optimized = true;
variable.SetFieldName("z01_read_textresp");
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
if (key == IdZ01_READ_TEXTResp) {
return ssSTZ01_READ_TEXTResp;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdZ01_READ_TEXTResp.Key.AsGuid) {
return ssSTZ01_READ_TEXTResp;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTZ01_READ_TEXTResp.FillFromOther((IRecord) other.AttributeGet(IdZ01_READ_TEXTResp));
}
} // RC_044a5f839fa7637f6ee7b728352fd227
/// <summary>
/// RecordList type <code>Z01_READ_TEXTRespRecordList</code> that represents a record list of
///  <code>Z01_READ_TEXTResp</code>
/// </summary>
public partial class RL_d1e4aa8650ef01eaa459bc6426d6f095 : GenericRecordList<RC_044a5f839fa7637f6ee7b728352fd227>, IEnumerable, IEnumerator {

protected override RC_044a5f839fa7637f6ee7b728352fd227 GetElementDefaultValue() {
return new RC_044a5f839fa7637f6ee7b728352fd227();
}

public T[] ToArray<T>(Func<RC_044a5f839fa7637f6ee7b728352fd227, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d1e4aa8650ef01eaa459bc6426d6f095 recordList, Func<RC_044a5f839fa7637f6ee7b728352fd227, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d1e4aa8650ef01eaa459bc6426d6f095(RC_044a5f839fa7637f6ee7b728352fd227[] array) {
  RL_d1e4aa8650ef01eaa459bc6426d6f095 result = new RL_d1e4aa8650ef01eaa459bc6426d6f095();
result.InnerFromArray(array);
    return result;
}

public static RL_d1e4aa8650ef01eaa459bc6426d6f095 ToList<T>(T[] array, Func <T, RC_044a5f839fa7637f6ee7b728352fd227> converter) {
  RL_d1e4aa8650ef01eaa459bc6426d6f095 result = new RL_d1e4aa8650ef01eaa459bc6426d6f095();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d1e4aa8650ef01eaa459bc6426d6f095 FromRestList<T>(RestList<T> restList, Func <T, RC_044a5f839fa7637f6ee7b728352fd227> converter) {
  RL_d1e4aa8650ef01eaa459bc6426d6f095 result = new RL_d1e4aa8650ef01eaa459bc6426d6f095();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d1e4aa8650ef01eaa459bc6426d6f095() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_044a5f839fa7637f6ee7b728352fd227> NewList() {
return new RL_d1e4aa8650ef01eaa459bc6426d6f095();
}


} // RL_d1e4aa8650ef01eaa459bc6426d6f095
}

