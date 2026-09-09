namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Cn1ezof6VEOld+PsRRuCTA)
///  <code>RC_fd17f3b5298bdff8f863d6f0335db07c</code> that represent
/// s <code>Region_TextRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: Region_TextRegionRecord
public partial struct RC_fd17f3b5298bdff8f863d6f0335db07c : ITypedRecord<RC_fd17f3b5298bdff8f863d6f0335db07c> {
internal static readonly GlobalObjectKey IdRegion_Text = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*M2f5izoH87IwAmWG_W2a+g");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public string ssRegion_Text;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_fd17f3b5298bdff8f863d6f0335db07c() {
OptimizedAttributes = null;
ssRegion_Text = "";
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENRegion.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENRegion.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssRegion_Text = r.ReadText(index++, "Region_TextRegionRecord.Region_Text", "");
ssENRegion.Read( r, ref index);
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
public void ReadIM(RC_fd17f3b5298bdff8f863d6f0335db07c r) {
this = r;
}


public static bool operator == (RC_fd17f3b5298bdff8f863d6f0335db07c a, RC_fd17f3b5298bdff8f863d6f0335db07c b) {
if (a.ssRegion_Text != b.ssRegion_Text) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_fd17f3b5298bdff8f863d6f0335db07c a, RC_fd17f3b5298bdff8f863d6f0335db07c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_fd17f3b5298bdff8f863d6f0335db07c)) return false;
return (this == (RC_fd17f3b5298bdff8f863d6f0335db07c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssRegion_Text.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRegion.InternalRecursiveSave();
}


public RC_fd17f3b5298bdff8f863d6f0335db07c Duplicate() {
RC_fd17f3b5298bdff8f863d6f0335db07c t;
t.ssRegion_Text = this.ssRegion_Text;
t.ssENRegion = (EN_31f501c551d210017fcb34b5237e3390EntityRecord)this.ssENRegion.Duplicate();
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
if (head == "region_text") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region_Text")) variable.Value = ssRegion_Text; else variable.Optimized = true;
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssENRegion; else variable.Optimized = true;
variable.SetFieldName("region");
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
if (key == IdRegion_Text) {
return ssRegion_Text;
}
if (key == IdRegion) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRegion_Text.Key.AsGuid) {
return ssRegion_Text;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssRegion_Text = (string) other.AttributeGet(IdRegion_Text);
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_fd17f3b5298bdff8f863d6f0335db07c
/// <summary>
/// RecordList type <code>Region_TextRegionRecordList</code> that represents a record list of
///  <code>Text, Region</code>
/// </summary>
public partial class RL_07bd6e6f32ae098d324b78b5f3777516 : GenericRecordList<RC_fd17f3b5298bdff8f863d6f0335db07c>, IEnumerable, IEnumerator {

protected override RC_fd17f3b5298bdff8f863d6f0335db07c GetElementDefaultValue() {
return new RC_fd17f3b5298bdff8f863d6f0335db07c();
}

public T[] ToArray<T>(Func<RC_fd17f3b5298bdff8f863d6f0335db07c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_07bd6e6f32ae098d324b78b5f3777516 recordList, Func<RC_fd17f3b5298bdff8f863d6f0335db07c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_07bd6e6f32ae098d324b78b5f3777516(RC_fd17f3b5298bdff8f863d6f0335db07c[] array) {
  RL_07bd6e6f32ae098d324b78b5f3777516 result = new RL_07bd6e6f32ae098d324b78b5f3777516();
result.InnerFromArray(array);
    return result;
}

public static RL_07bd6e6f32ae098d324b78b5f3777516 ToList<T>(T[] array, Func <T, RC_fd17f3b5298bdff8f863d6f0335db07c> converter) {
  RL_07bd6e6f32ae098d324b78b5f3777516 result = new RL_07bd6e6f32ae098d324b78b5f3777516();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_07bd6e6f32ae098d324b78b5f3777516 FromRestList<T>(RestList<T> restList, Func <T, RC_fd17f3b5298bdff8f863d6f0335db07c> converter) {
  RL_07bd6e6f32ae098d324b78b5f3777516 result = new RL_07bd6e6f32ae098d324b78b5f3777516();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_07bd6e6f32ae098d324b78b5f3777516() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_fd17f3b5298bdff8f863d6f0335db07c> NewList() {
return new RL_07bd6e6f32ae098d324b78b5f3777516();
}


} // RL_07bd6e6f32ae098d324b78b5f3777516
}

