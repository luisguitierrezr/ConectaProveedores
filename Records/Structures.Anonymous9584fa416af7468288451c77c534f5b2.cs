namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (QfqElfdqgkaIRRx3xTT1sg)
///  <code>RC_0c0b0735f68bd3b21998309e63b78a99</code> that represent
/// s <code>Z01_READ_TEXTReqRecord</code> <p>Description: </p>
/// </summary>
// Name: Z01_READ_TEXTReqRecord
public partial struct RC_0c0b0735f68bd3b21998309e63b78a99 : ITypedRecord<RC_0c0b0735f68bd3b21998309e63b78a99> {
internal static readonly GlobalObjectKey IdZ01_READ_TEXTReq = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NQcLDIv2stMZmDCeY7eKmQ");

public ST_c4a97e6963b2cd0d749b56dde8d26a02Structure ssSTZ01_READ_TEXTReq;


public static implicit operator ST_c4a97e6963b2cd0d749b56dde8d26a02Structure( RC_0c0b0735f68bd3b21998309e63b78a99 r) {
return r.ssSTZ01_READ_TEXTReq;
}

public static implicit operator RC_0c0b0735f68bd3b21998309e63b78a99 (ST_c4a97e6963b2cd0d749b56dde8d26a02Structure r) {
RC_0c0b0735f68bd3b21998309e63b78a99 res = new RC_0c0b0735f68bd3b21998309e63b78a99 ();
res.ssSTZ01_READ_TEXTReq = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_0c0b0735f68bd3b21998309e63b78a99() {
OptimizedAttributes = null;
ssSTZ01_READ_TEXTReq = new ST_c4a97e6963b2cd0d749b56dde8d26a02Structure();
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
    ssSTZ01_READ_TEXTReq.OptimizedAttributes = value[0];
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
ssSTZ01_READ_TEXTReq.Read( r, ref index);
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
public void ReadIM(RC_0c0b0735f68bd3b21998309e63b78a99 r) {
this = r;
}


public static bool operator == (RC_0c0b0735f68bd3b21998309e63b78a99 a, RC_0c0b0735f68bd3b21998309e63b78a99 b) {
if (a.ssSTZ01_READ_TEXTReq != b.ssSTZ01_READ_TEXTReq) return false;
return true;
}

public static bool operator != (RC_0c0b0735f68bd3b21998309e63b78a99 a, RC_0c0b0735f68bd3b21998309e63b78a99 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_0c0b0735f68bd3b21998309e63b78a99)) return false;
return (this == (RC_0c0b0735f68bd3b21998309e63b78a99)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTZ01_READ_TEXTReq.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTZ01_READ_TEXTReq.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTZ01_READ_TEXTReq.InternalRecursiveSave();
}


public RC_0c0b0735f68bd3b21998309e63b78a99 Duplicate() {
RC_0c0b0735f68bd3b21998309e63b78a99 t;
t.ssSTZ01_READ_TEXTReq = (ST_c4a97e6963b2cd0d749b56dde8d26a02Structure)this.ssSTZ01_READ_TEXTReq.Duplicate();
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
if (head == "z01_read_textreq") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Z01_READ_TEXTReq")) variable.Value = ssSTZ01_READ_TEXTReq; else variable.Optimized = true;
variable.SetFieldName("z01_read_textreq");
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
if (key == IdZ01_READ_TEXTReq) {
return ssSTZ01_READ_TEXTReq;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdZ01_READ_TEXTReq.Key.AsGuid) {
return ssSTZ01_READ_TEXTReq;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTZ01_READ_TEXTReq.FillFromOther((IRecord) other.AttributeGet(IdZ01_READ_TEXTReq));
}
} // RC_0c0b0735f68bd3b21998309e63b78a99
/// <summary>
/// RecordList type <code>Z01_READ_TEXTReqRecordList</code> that represents a record list of
///  <code>Z01_READ_TEXTReq</code>
/// </summary>
public partial class RL_10dc76a10ed541d9fbe2b9d213a29fd1 : GenericRecordList<RC_0c0b0735f68bd3b21998309e63b78a99>, IEnumerable, IEnumerator {

protected override RC_0c0b0735f68bd3b21998309e63b78a99 GetElementDefaultValue() {
return new RC_0c0b0735f68bd3b21998309e63b78a99();
}

public T[] ToArray<T>(Func<RC_0c0b0735f68bd3b21998309e63b78a99, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_10dc76a10ed541d9fbe2b9d213a29fd1 recordList, Func<RC_0c0b0735f68bd3b21998309e63b78a99, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_10dc76a10ed541d9fbe2b9d213a29fd1(RC_0c0b0735f68bd3b21998309e63b78a99[] array) {
  RL_10dc76a10ed541d9fbe2b9d213a29fd1 result = new RL_10dc76a10ed541d9fbe2b9d213a29fd1();
result.InnerFromArray(array);
    return result;
}

public static RL_10dc76a10ed541d9fbe2b9d213a29fd1 ToList<T>(T[] array, Func <T, RC_0c0b0735f68bd3b21998309e63b78a99> converter) {
  RL_10dc76a10ed541d9fbe2b9d213a29fd1 result = new RL_10dc76a10ed541d9fbe2b9d213a29fd1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_10dc76a10ed541d9fbe2b9d213a29fd1 FromRestList<T>(RestList<T> restList, Func <T, RC_0c0b0735f68bd3b21998309e63b78a99> converter) {
  RL_10dc76a10ed541d9fbe2b9d213a29fd1 result = new RL_10dc76a10ed541d9fbe2b9d213a29fd1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_10dc76a10ed541d9fbe2b9d213a29fd1() : base() {
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
protected override OSList<RC_0c0b0735f68bd3b21998309e63b78a99> NewList() {
return new RL_10dc76a10ed541d9fbe2b9d213a29fd1();
}


} // RL_10dc76a10ed541d9fbe2b9d213a29fd1
}

