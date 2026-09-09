namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (axQfeSt_3UeYy95k1bvamw)
///  <code>RC_ca61515b5f1b81a3f63a72f69693ae36</code> that represents <code>TextRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: TextRecord
public partial struct RC_ca61515b5f1b81a3f63a72f69693ae36 : ITypedRecord<RC_ca61515b5f1b81a3f63a72f69693ae36> {
internal static readonly GlobalObjectKey IdText = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*W1Fhyhtfo4H2OnL2lpOuNg");

public string ssText;


public BitArray OptimizedAttributes;

public RC_ca61515b5f1b81a3f63a72f69693ae36() {
OptimizedAttributes = null;
ssText = "";
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
ssText = r.ReadText(index++, "TextRecord.Text", "");
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
public void ReadIM(RC_ca61515b5f1b81a3f63a72f69693ae36 r) {
this = r;
}


public static bool operator == (RC_ca61515b5f1b81a3f63a72f69693ae36 a, RC_ca61515b5f1b81a3f63a72f69693ae36 b) {
if (a.ssText != b.ssText) return false;
return true;
}

public static bool operator != (RC_ca61515b5f1b81a3f63a72f69693ae36 a, RC_ca61515b5f1b81a3f63a72f69693ae36 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ca61515b5f1b81a3f63a72f69693ae36)) return false;
return (this == (RC_ca61515b5f1b81a3f63a72f69693ae36)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssText.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_ca61515b5f1b81a3f63a72f69693ae36 Duplicate() {
RC_ca61515b5f1b81a3f63a72f69693ae36 t;
t.ssText = this.ssText;
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
if (head == "text") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Text")) variable.Value = ssText; else variable.Optimized = true;
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
if (key == IdText) {
return ssText;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdText.Key.AsGuid) {
return ssText;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssText = (string) other.AttributeGet(IdText);
}
} // RC_ca61515b5f1b81a3f63a72f69693ae36
/// <summary>
/// RecordList type <code>TextRecordList</code> that represents a record list of <code>Text</code>
/// </summary>
public partial class RL_df53376d76478ddd40257fed0b6f76e8 : GenericRecordList<RC_ca61515b5f1b81a3f63a72f69693ae36>, IEnumerable, IEnumerator {

protected override RC_ca61515b5f1b81a3f63a72f69693ae36 GetElementDefaultValue() {
return new RC_ca61515b5f1b81a3f63a72f69693ae36();
}

public T[] ToArray<T>(Func<RC_ca61515b5f1b81a3f63a72f69693ae36, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_df53376d76478ddd40257fed0b6f76e8 recordList, Func<RC_ca61515b5f1b81a3f63a72f69693ae36, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_df53376d76478ddd40257fed0b6f76e8(RC_ca61515b5f1b81a3f63a72f69693ae36[] array) {
  RL_df53376d76478ddd40257fed0b6f76e8 result = new RL_df53376d76478ddd40257fed0b6f76e8();
result.InnerFromArray(array);
    return result;
}

public static RL_df53376d76478ddd40257fed0b6f76e8 ToList<T>(T[] array, Func <T, RC_ca61515b5f1b81a3f63a72f69693ae36> converter) {
  RL_df53376d76478ddd40257fed0b6f76e8 result = new RL_df53376d76478ddd40257fed0b6f76e8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_df53376d76478ddd40257fed0b6f76e8 FromRestList<T>(RestList<T> restList, Func <T, RC_ca61515b5f1b81a3f63a72f69693ae36> converter) {
  RL_df53376d76478ddd40257fed0b6f76e8 result = new RL_df53376d76478ddd40257fed0b6f76e8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_df53376d76478ddd40257fed0b6f76e8() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_ca61515b5f1b81a3f63a72f69693ae36> NewList() {
return new RL_df53376d76478ddd40257fed0b6f76e8();
}


} // RL_df53376d76478ddd40257fed0b6f76e8
}

