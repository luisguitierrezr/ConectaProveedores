namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Ib3va_ZfAUaU2EWHErhraQ)
///  <code>RC_4025a6e81cda8c0b3682c310ca5a8765</code> that represents <code>TextRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: TextRecord
public partial struct RC_4025a6e81cda8c0b3682c310ca5a8765 : ITypedRecord<RC_4025a6e81cda8c0b3682c310ca5a8765> {
internal static readonly GlobalObjectKey IdText = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*6KYlQNocC4w2gsMQylqHZQ");

public ST_1f76dfa138680efe9e5e11deb3c828b8Structure ssSTText;


public static implicit operator ST_1f76dfa138680efe9e5e11deb3c828b8Structure( RC_4025a6e81cda8c0b3682c310ca5a8765 r) {
return r.ssSTText;
}

public static implicit operator RC_4025a6e81cda8c0b3682c310ca5a8765 (ST_1f76dfa138680efe9e5e11deb3c828b8Structure r) {
RC_4025a6e81cda8c0b3682c310ca5a8765 res = new RC_4025a6e81cda8c0b3682c310ca5a8765 ();
res.ssSTText = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_4025a6e81cda8c0b3682c310ca5a8765() {
OptimizedAttributes = null;
ssSTText = new ST_1f76dfa138680efe9e5e11deb3c828b8Structure();
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
    ssSTText.OptimizedAttributes = value[0];
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
ssSTText.Read( r, ref index);
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
public void ReadIM(RC_4025a6e81cda8c0b3682c310ca5a8765 r) {
this = r;
}


public static bool operator == (RC_4025a6e81cda8c0b3682c310ca5a8765 a, RC_4025a6e81cda8c0b3682c310ca5a8765 b) {
if (a.ssSTText != b.ssSTText) return false;
return true;
}

public static bool operator != (RC_4025a6e81cda8c0b3682c310ca5a8765 a, RC_4025a6e81cda8c0b3682c310ca5a8765 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_4025a6e81cda8c0b3682c310ca5a8765)) return false;
return (this == (RC_4025a6e81cda8c0b3682c310ca5a8765)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTText.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTText.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTText.InternalRecursiveSave();
}


public RC_4025a6e81cda8c0b3682c310ca5a8765 Duplicate() {
RC_4025a6e81cda8c0b3682c310ca5a8765 t;
t.ssSTText = (ST_1f76dfa138680efe9e5e11deb3c828b8Structure)this.ssSTText.Duplicate();
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
if (!VarValue.FieldIsOptimized(parent, baseName + ".Text")) variable.Value = ssSTText; else variable.Optimized = true;
variable.SetFieldName("text");
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
return ssSTText;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdText.Key.AsGuid) {
return ssSTText;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTText.FillFromOther((IRecord) other.AttributeGet(IdText));
}
} // RC_4025a6e81cda8c0b3682c310ca5a8765
/// <summary>
/// RecordList type <code>TextRecordList</code> that represents a record list of <code>Text</code>
/// </summary>
public partial class RL_5c6c8b32275d20f737a40af96822f0ed : GenericRecordList<RC_4025a6e81cda8c0b3682c310ca5a8765>, IEnumerable, IEnumerator {

protected override RC_4025a6e81cda8c0b3682c310ca5a8765 GetElementDefaultValue() {
return new RC_4025a6e81cda8c0b3682c310ca5a8765();
}

public T[] ToArray<T>(Func<RC_4025a6e81cda8c0b3682c310ca5a8765, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5c6c8b32275d20f737a40af96822f0ed recordList, Func<RC_4025a6e81cda8c0b3682c310ca5a8765, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5c6c8b32275d20f737a40af96822f0ed(RC_4025a6e81cda8c0b3682c310ca5a8765[] array) {
  RL_5c6c8b32275d20f737a40af96822f0ed result = new RL_5c6c8b32275d20f737a40af96822f0ed();
result.InnerFromArray(array);
    return result;
}

public static RL_5c6c8b32275d20f737a40af96822f0ed ToList<T>(T[] array, Func <T, RC_4025a6e81cda8c0b3682c310ca5a8765> converter) {
  RL_5c6c8b32275d20f737a40af96822f0ed result = new RL_5c6c8b32275d20f737a40af96822f0ed();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5c6c8b32275d20f737a40af96822f0ed FromRestList<T>(RestList<T> restList, Func <T, RC_4025a6e81cda8c0b3682c310ca5a8765> converter) {
  RL_5c6c8b32275d20f737a40af96822f0ed result = new RL_5c6c8b32275d20f737a40af96822f0ed();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5c6c8b32275d20f737a40af96822f0ed() : base() {
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
protected override OSList<RC_4025a6e81cda8c0b3682c310ca5a8765> NewList() {
return new RL_5c6c8b32275d20f737a40af96822f0ed();
}


} // RL_5c6c8b32275d20f737a40af96822f0ed
}

