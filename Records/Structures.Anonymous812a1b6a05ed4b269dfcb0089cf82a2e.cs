namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (ahsqge0FJkud_LAInPgqLg)
///  <code>RC_2f11367ef093a7d6654be614b79c6c4b</code> that represent
/// s <code>PostCarganovimResponseWrapperRecord</code> <p>Description: </p>
/// </summary>
// Name: PostCarganovimResponseWrapperRecord
public partial struct RC_2f11367ef093a7d6654be614b79c6c4b : ITypedRecord<RC_2f11367ef093a7d6654be614b79c6c4b> {
internal static readonly GlobalObjectKey IdPostCarganovimResponseWrapper = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*fjYRL5Pw1qdlS+YUt5xsSw");

public ST_6636acdf9f49922edfd43b4865475460Structure ssSTPostCarganovimResponseWrapper;


public static implicit operator ST_6636acdf9f49922edfd43b4865475460Structure( RC_2f11367ef093a7d6654be614b79c6c4b r) {
return r.ssSTPostCarganovimResponseWrapper;
}

public static implicit operator RC_2f11367ef093a7d6654be614b79c6c4b (ST_6636acdf9f49922edfd43b4865475460Structure r) {
RC_2f11367ef093a7d6654be614b79c6c4b res = new RC_2f11367ef093a7d6654be614b79c6c4b ();
res.ssSTPostCarganovimResponseWrapper = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_2f11367ef093a7d6654be614b79c6c4b() {
OptimizedAttributes = null;
ssSTPostCarganovimResponseWrapper = new ST_6636acdf9f49922edfd43b4865475460Structure();
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
    ssSTPostCarganovimResponseWrapper.OptimizedAttributes = value[0];
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
ssSTPostCarganovimResponseWrapper.Read( r, ref index);
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
public void ReadIM(RC_2f11367ef093a7d6654be614b79c6c4b r) {
this = r;
}


public static bool operator == (RC_2f11367ef093a7d6654be614b79c6c4b a, RC_2f11367ef093a7d6654be614b79c6c4b b) {
if (a.ssSTPostCarganovimResponseWrapper != b.ssSTPostCarganovimResponseWrapper) return false;
return true;
}

public static bool operator != (RC_2f11367ef093a7d6654be614b79c6c4b a, RC_2f11367ef093a7d6654be614b79c6c4b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_2f11367ef093a7d6654be614b79c6c4b)) return false;
return (this == (RC_2f11367ef093a7d6654be614b79c6c4b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTPostCarganovimResponseWrapper.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTPostCarganovimResponseWrapper.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTPostCarganovimResponseWrapper.InternalRecursiveSave();
}


public RC_2f11367ef093a7d6654be614b79c6c4b Duplicate() {
RC_2f11367ef093a7d6654be614b79c6c4b t;
t.ssSTPostCarganovimResponseWrapper = (ST_6636acdf9f49922edfd43b4865475460Structure)this.ssSTPostCarganovimResponseWrapper.Duplicate();
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
if (head == "postcarganovimresponsewrapper") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PostCarganovimResponseWrapper")) variable.Value = ssSTPostCarganovimResponseWrapper; else variable.Optimized = true;
variable.SetFieldName("postcarganovimresponsewrapper");
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
if (key == IdPostCarganovimResponseWrapper) {
return ssSTPostCarganovimResponseWrapper;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPostCarganovimResponseWrapper.Key.AsGuid) {
return ssSTPostCarganovimResponseWrapper;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTPostCarganovimResponseWrapper.FillFromOther((IRecord) other.AttributeGet(IdPostCarganovimResponseWrapper));
}
} // RC_2f11367ef093a7d6654be614b79c6c4b
/// <summary>
/// RecordList type <code>PostCarganovimResponseWrapperRecordList</code> that represents a record list
///  of <code>PostCarganovimResponseWrapper</code>
/// </summary>
public partial class RL_d2b24e199d81107da86438eb427c8206 : GenericRecordList<RC_2f11367ef093a7d6654be614b79c6c4b>, IEnumerable, IEnumerator {

protected override RC_2f11367ef093a7d6654be614b79c6c4b GetElementDefaultValue() {
return new RC_2f11367ef093a7d6654be614b79c6c4b();
}

public T[] ToArray<T>(Func<RC_2f11367ef093a7d6654be614b79c6c4b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d2b24e199d81107da86438eb427c8206 recordList, Func<RC_2f11367ef093a7d6654be614b79c6c4b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d2b24e199d81107da86438eb427c8206(RC_2f11367ef093a7d6654be614b79c6c4b[] array) {
  RL_d2b24e199d81107da86438eb427c8206 result = new RL_d2b24e199d81107da86438eb427c8206();
result.InnerFromArray(array);
    return result;
}

public static RL_d2b24e199d81107da86438eb427c8206 ToList<T>(T[] array, Func <T, RC_2f11367ef093a7d6654be614b79c6c4b> converter) {
  RL_d2b24e199d81107da86438eb427c8206 result = new RL_d2b24e199d81107da86438eb427c8206();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d2b24e199d81107da86438eb427c8206 FromRestList<T>(RestList<T> restList, Func <T, RC_2f11367ef093a7d6654be614b79c6c4b> converter) {
  RL_d2b24e199d81107da86438eb427c8206 result = new RL_d2b24e199d81107da86438eb427c8206();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d2b24e199d81107da86438eb427c8206() : base() {
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
protected override OSList<RC_2f11367ef093a7d6654be614b79c6c4b> NewList() {
return new RL_d2b24e199d81107da86438eb427c8206();
}


} // RL_d2b24e199d81107da86438eb427c8206
}

