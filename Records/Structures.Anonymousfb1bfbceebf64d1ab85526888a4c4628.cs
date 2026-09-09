namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (zvsb+_brGk24VSaIikxGKA)
///  <code>RC_8a1c045009e7a849632ad52d45f16812</code> that represents <code>TextText_2Record</code
/// > <p>Description: </p>
/// </summary>
// Name: TextText_2Record
public partial struct RC_8a1c045009e7a849632ad52d45f16812 : ITypedRecord<RC_8a1c045009e7a849632ad52d45f16812> {
internal static readonly GlobalObjectKey IdText = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*6KYlQNocC4w2gsMQylqHZQ");
internal static readonly GlobalObjectKey IdText_2 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*AyUOkPxBDUpc4ilxEKZOrQ");

public ST_1f76dfa138680efe9e5e11deb3c828b8Structure ssSTText;

public ST_1f76dfa138680efe9e5e11deb3c828b8Structure ssSTText_2;


public BitArray OptimizedAttributes;

public RC_8a1c045009e7a849632ad52d45f16812() {
OptimizedAttributes = null;
ssSTText = new ST_1f76dfa138680efe9e5e11deb3c828b8Structure();
ssSTText_2 = new ST_1f76dfa138680efe9e5e11deb3c828b8Structure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = null;
    all[1] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTText.OptimizedAttributes = value[0];
    ssSTText_2.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = null;
    all[1] = null;
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
ssSTText_2.Read( r, ref index);
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
public void ReadIM(RC_8a1c045009e7a849632ad52d45f16812 r) {
this = r;
}


public static bool operator == (RC_8a1c045009e7a849632ad52d45f16812 a, RC_8a1c045009e7a849632ad52d45f16812 b) {
if (a.ssSTText != b.ssSTText) return false;
if (a.ssSTText_2 != b.ssSTText_2) return false;
return true;
}

public static bool operator != (RC_8a1c045009e7a849632ad52d45f16812 a, RC_8a1c045009e7a849632ad52d45f16812 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8a1c045009e7a849632ad52d45f16812)) return false;
return (this == (RC_8a1c045009e7a849632ad52d45f16812)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTText.GetHashCode()
 ^ ssSTText_2.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTText.RecursiveReset();
ssSTText_2.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTText.InternalRecursiveSave();
ssSTText_2.InternalRecursiveSave();
}


public RC_8a1c045009e7a849632ad52d45f16812 Duplicate() {
RC_8a1c045009e7a849632ad52d45f16812 t;
t.ssSTText = (ST_1f76dfa138680efe9e5e11deb3c828b8Structure)this.ssSTText.Duplicate();
t.ssSTText_2 = (ST_1f76dfa138680efe9e5e11deb3c828b8Structure)this.ssSTText_2.Duplicate();
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
} else if (head == "text_2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Text_2")) variable.Value = ssSTText_2; else variable.Optimized = true;
variable.SetFieldName("text_2");
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
if (key == IdText_2) {
return ssSTText_2;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdText.Key.AsGuid) {
return ssSTText;
}
if (attributeKey == IdText_2.Key.AsGuid) {
return ssSTText_2;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTText.FillFromOther((IRecord) other.AttributeGet(IdText));
ssSTText_2.FillFromOther((IRecord) other.AttributeGet(IdText_2));
}
} // RC_8a1c045009e7a849632ad52d45f16812
/// <summary>
/// RecordList type <code>TextText_2RecordList</code> that represents a record list of <code>Text,
///  Text</code>
/// </summary>
public partial class RL_e39abdd7d353c45cf34d88d73eb993c9 : GenericRecordList<RC_8a1c045009e7a849632ad52d45f16812>, IEnumerable, IEnumerator {

protected override RC_8a1c045009e7a849632ad52d45f16812 GetElementDefaultValue() {
return new RC_8a1c045009e7a849632ad52d45f16812();
}

public T[] ToArray<T>(Func<RC_8a1c045009e7a849632ad52d45f16812, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e39abdd7d353c45cf34d88d73eb993c9 recordList, Func<RC_8a1c045009e7a849632ad52d45f16812, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e39abdd7d353c45cf34d88d73eb993c9(RC_8a1c045009e7a849632ad52d45f16812[] array) {
  RL_e39abdd7d353c45cf34d88d73eb993c9 result = new RL_e39abdd7d353c45cf34d88d73eb993c9();
result.InnerFromArray(array);
    return result;
}

public static RL_e39abdd7d353c45cf34d88d73eb993c9 ToList<T>(T[] array, Func <T, RC_8a1c045009e7a849632ad52d45f16812> converter) {
  RL_e39abdd7d353c45cf34d88d73eb993c9 result = new RL_e39abdd7d353c45cf34d88d73eb993c9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e39abdd7d353c45cf34d88d73eb993c9 FromRestList<T>(RestList<T> restList, Func <T, RC_8a1c045009e7a849632ad52d45f16812> converter) {
  RL_e39abdd7d353c45cf34d88d73eb993c9 result = new RL_e39abdd7d353c45cf34d88d73eb993c9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e39abdd7d353c45cf34d88d73eb993c9() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = null;
def[1] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_8a1c045009e7a849632ad52d45f16812> NewList() {
return new RL_e39abdd7d353c45cf34d88d73eb993c9();
}


} // RL_e39abdd7d353c45cf34d88d73eb993c9
}

