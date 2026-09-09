namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (SzJ+6pF8A0aNyYgA57tE5Q)
///  <code>RC_71c4d11a939585674ac683863dab8f61</code> that represents <code>HTTPHeaderRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: HTTPHeaderRecord
public partial struct RC_71c4d11a939585674ac683863dab8f61 : ITypedRecord<RC_71c4d11a939585674ac683863dab8f61> {
internal static readonly GlobalObjectKey IdHTTPHeader = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*GtHEcZWTZ4VKxoOGPauPYQ");

public ST_3cf3b984041595af1703070620d6367bStructure ssSTHTTPHeader;


public static implicit operator ST_3cf3b984041595af1703070620d6367bStructure( RC_71c4d11a939585674ac683863dab8f61 r) {
return r.ssSTHTTPHeader;
}

public static implicit operator RC_71c4d11a939585674ac683863dab8f61 (ST_3cf3b984041595af1703070620d6367bStructure r) {
RC_71c4d11a939585674ac683863dab8f61 res = new RC_71c4d11a939585674ac683863dab8f61 ();
res.ssSTHTTPHeader = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_71c4d11a939585674ac683863dab8f61() {
OptimizedAttributes = null;
ssSTHTTPHeader = new ST_3cf3b984041595af1703070620d6367bStructure();
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
    ssSTHTTPHeader.OptimizedAttributes = value[0];
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
ssSTHTTPHeader.Read( r, ref index);
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
public void ReadIM(RC_71c4d11a939585674ac683863dab8f61 r) {
this = r;
}


public static bool operator == (RC_71c4d11a939585674ac683863dab8f61 a, RC_71c4d11a939585674ac683863dab8f61 b) {
if (a.ssSTHTTPHeader != b.ssSTHTTPHeader) return false;
return true;
}

public static bool operator != (RC_71c4d11a939585674ac683863dab8f61 a, RC_71c4d11a939585674ac683863dab8f61 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_71c4d11a939585674ac683863dab8f61)) return false;
return (this == (RC_71c4d11a939585674ac683863dab8f61)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTHTTPHeader.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTHTTPHeader.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTHTTPHeader.InternalRecursiveSave();
}


public RC_71c4d11a939585674ac683863dab8f61 Duplicate() {
RC_71c4d11a939585674ac683863dab8f61 t;
t.ssSTHTTPHeader = (ST_3cf3b984041595af1703070620d6367bStructure)this.ssSTHTTPHeader.Duplicate();
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
if (head == "httpheader") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HTTPHeader")) variable.Value = ssSTHTTPHeader; else variable.Optimized = true;
variable.SetFieldName("httpheader");
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
if (key == IdHTTPHeader) {
return ssSTHTTPHeader;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdHTTPHeader.Key.AsGuid) {
return ssSTHTTPHeader;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTHTTPHeader.FillFromOther((IRecord) other.AttributeGet(IdHTTPHeader));
}
} // RC_71c4d11a939585674ac683863dab8f61
/// <summary>
/// RecordList type <code>HTTPHeaderRecordList</code> that represents a record list of
///  <code>HTTPHeader</code>
/// </summary>
public partial class RL_75ae46f3d9789236bc6b442dd0740ba3 : GenericRecordList<RC_71c4d11a939585674ac683863dab8f61>, IEnumerable, IEnumerator {

protected override RC_71c4d11a939585674ac683863dab8f61 GetElementDefaultValue() {
return new RC_71c4d11a939585674ac683863dab8f61();
}

public T[] ToArray<T>(Func<RC_71c4d11a939585674ac683863dab8f61, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_75ae46f3d9789236bc6b442dd0740ba3 recordList, Func<RC_71c4d11a939585674ac683863dab8f61, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_75ae46f3d9789236bc6b442dd0740ba3(RC_71c4d11a939585674ac683863dab8f61[] array) {
  RL_75ae46f3d9789236bc6b442dd0740ba3 result = new RL_75ae46f3d9789236bc6b442dd0740ba3();
result.InnerFromArray(array);
    return result;
}

public static RL_75ae46f3d9789236bc6b442dd0740ba3 ToList<T>(T[] array, Func <T, RC_71c4d11a939585674ac683863dab8f61> converter) {
  RL_75ae46f3d9789236bc6b442dd0740ba3 result = new RL_75ae46f3d9789236bc6b442dd0740ba3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_75ae46f3d9789236bc6b442dd0740ba3 FromRestList<T>(RestList<T> restList, Func <T, RC_71c4d11a939585674ac683863dab8f61> converter) {
  RL_75ae46f3d9789236bc6b442dd0740ba3 result = new RL_75ae46f3d9789236bc6b442dd0740ba3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_75ae46f3d9789236bc6b442dd0740ba3() : base() {
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
protected override OSList<RC_71c4d11a939585674ac683863dab8f61> NewList() {
return new RL_75ae46f3d9789236bc6b442dd0740ba3();
}


} // RL_75ae46f3d9789236bc6b442dd0740ba3
}

