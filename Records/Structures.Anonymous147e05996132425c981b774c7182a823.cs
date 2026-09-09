namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (mQV+FDJhXEKYG3dMcYKoIw)
///  <code>RC_d2eb0d0bdf3678ac335e4faafec1c741</code> that represents <code>NameTextIdRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: NameTextIdRecord
public partial struct RC_d2eb0d0bdf3678ac335e4faafec1c741 : ITypedRecord<RC_d2eb0d0bdf3678ac335e4faafec1c741> {
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Y+cKFFxbDlVfkzJLEj4LTw");
internal static readonly GlobalObjectKey IdText = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*W1Fhyhtfo4H2OnL2lpOuNg");
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*zomPRnthAFxRcbFBoj6__w");

public string ssName;

public string ssText;

public long ssId;


public BitArray OptimizedAttributes;

public RC_d2eb0d0bdf3678ac335e4faafec1c741() {
OptimizedAttributes = null;
ssName = "";
ssText = "";
ssId = 0L;
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
ssName = r.ReadText(index++, "NameTextIdRecord.Name", "");
ssText = r.ReadText(index++, "NameTextIdRecord.Text", "");
ssId = r.ReadLongInteger(index++, "NameTextIdRecord.Id", 0L);
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
public void ReadIM(RC_d2eb0d0bdf3678ac335e4faafec1c741 r) {
this = r;
}


public static bool operator == (RC_d2eb0d0bdf3678ac335e4faafec1c741 a, RC_d2eb0d0bdf3678ac335e4faafec1c741 b) {
if (a.ssName != b.ssName) return false;
if (a.ssText != b.ssText) return false;
if (a.ssId != b.ssId) return false;
return true;
}

public static bool operator != (RC_d2eb0d0bdf3678ac335e4faafec1c741 a, RC_d2eb0d0bdf3678ac335e4faafec1c741 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d2eb0d0bdf3678ac335e4faafec1c741)) return false;
return (this == (RC_d2eb0d0bdf3678ac335e4faafec1c741)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssText.GetHashCode()
 ^ ssId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_d2eb0d0bdf3678ac335e4faafec1c741 Duplicate() {
RC_d2eb0d0bdf3678ac335e4faafec1c741 t;
t.ssName = this.ssName;
t.ssText = this.ssText;
t.ssId = this.ssId;
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
if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "text") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Text")) variable.Value = ssText; else variable.Optimized = true;
} else if (head == "id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Id")) variable.Value = ssId; else variable.Optimized = true;
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
if (key == IdName) {
return ssName;
}
if (key == IdText) {
return ssText;
}
if (key == IdId) {
return ssId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdText.Key.AsGuid) {
return ssText;
}
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssName = (string) other.AttributeGet(IdName);
ssText = (string) other.AttributeGet(IdText);
ssId = (long) other.AttributeGet(IdId);
}
} // RC_d2eb0d0bdf3678ac335e4faafec1c741
/// <summary>
/// RecordList type <code>NameTextIdRecordList</code> that represents a record list of <code>Text,
///  Text, LongInteger</code>
/// </summary>
public partial class RL_deea624669c8fc2034a6b63be32dc8c2 : GenericRecordList<RC_d2eb0d0bdf3678ac335e4faafec1c741>, IEnumerable, IEnumerator {

protected override RC_d2eb0d0bdf3678ac335e4faafec1c741 GetElementDefaultValue() {
return new RC_d2eb0d0bdf3678ac335e4faafec1c741();
}

public T[] ToArray<T>(Func<RC_d2eb0d0bdf3678ac335e4faafec1c741, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_deea624669c8fc2034a6b63be32dc8c2 recordList, Func<RC_d2eb0d0bdf3678ac335e4faafec1c741, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_deea624669c8fc2034a6b63be32dc8c2(RC_d2eb0d0bdf3678ac335e4faafec1c741[] array) {
  RL_deea624669c8fc2034a6b63be32dc8c2 result = new RL_deea624669c8fc2034a6b63be32dc8c2();
result.InnerFromArray(array);
    return result;
}

public static RL_deea624669c8fc2034a6b63be32dc8c2 ToList<T>(T[] array, Func <T, RC_d2eb0d0bdf3678ac335e4faafec1c741> converter) {
  RL_deea624669c8fc2034a6b63be32dc8c2 result = new RL_deea624669c8fc2034a6b63be32dc8c2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_deea624669c8fc2034a6b63be32dc8c2 FromRestList<T>(RestList<T> restList, Func <T, RC_d2eb0d0bdf3678ac335e4faafec1c741> converter) {
  RL_deea624669c8fc2034a6b63be32dc8c2 result = new RL_deea624669c8fc2034a6b63be32dc8c2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_deea624669c8fc2034a6b63be32dc8c2() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_d2eb0d0bdf3678ac335e4faafec1c741> NewList() {
return new RL_deea624669c8fc2034a6b63be32dc8c2();
}


} // RL_deea624669c8fc2034a6b63be32dc8c2
}

