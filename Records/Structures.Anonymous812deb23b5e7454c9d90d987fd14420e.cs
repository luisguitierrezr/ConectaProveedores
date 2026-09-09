namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (I+stgee1TEWdkNmH_RRCDg)
///  <code>RC_2dabb9c9cbdbc6ba6572314572d54c39</code> that represent
/// s <code>DisplayNameJobTitleIsNotMappedRecord</code> <p>Description: </p>
/// </summary>
// Name: DisplayNameJobTitleIsNotMappedRecord
public partial struct RC_2dabb9c9cbdbc6ba6572314572d54c39 : ITypedRecord<RC_2dabb9c9cbdbc6ba6572314572d54c39> {
internal static readonly GlobalObjectKey IdDisplayName = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*PU6nZpgtNNcVSjAjaHuEmg");
internal static readonly GlobalObjectKey IdJobTitle = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*v_98nFkJjAkxJOrQneYUfA");
internal static readonly GlobalObjectKey IdIsNotMapped = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*cW3sZjq+_Ppg7mG4z+BG1Q");

public string ssDisplayName;

public string ssJobTitle;

public bool ssIsNotMapped;


public BitArray OptimizedAttributes;

public RC_2dabb9c9cbdbc6ba6572314572d54c39() {
OptimizedAttributes = null;
ssDisplayName = "";
ssJobTitle = "";
ssIsNotMapped = false;
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
ssDisplayName = r.ReadText(index++, "DisplayNameJobTitleIsNotMappedRecord.DisplayName", "");
ssJobTitle = r.ReadText(index++, "DisplayNameJobTitleIsNotMappedRecord.JobTitle", "");
ssIsNotMapped = r.ReadBoolean(index++, "DisplayNameJobTitleIsNotMappedRecord.IsNotMapped", false);
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
public void ReadIM(RC_2dabb9c9cbdbc6ba6572314572d54c39 r) {
this = r;
}


public static bool operator == (RC_2dabb9c9cbdbc6ba6572314572d54c39 a, RC_2dabb9c9cbdbc6ba6572314572d54c39 b) {
if (a.ssDisplayName != b.ssDisplayName) return false;
if (a.ssJobTitle != b.ssJobTitle) return false;
if (a.ssIsNotMapped != b.ssIsNotMapped) return false;
return true;
}

public static bool operator != (RC_2dabb9c9cbdbc6ba6572314572d54c39 a, RC_2dabb9c9cbdbc6ba6572314572d54c39 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_2dabb9c9cbdbc6ba6572314572d54c39)) return false;
return (this == (RC_2dabb9c9cbdbc6ba6572314572d54c39)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssDisplayName.GetHashCode()
 ^ ssJobTitle.GetHashCode()
 ^ ssIsNotMapped.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_2dabb9c9cbdbc6ba6572314572d54c39 Duplicate() {
RC_2dabb9c9cbdbc6ba6572314572d54c39 t;
t.ssDisplayName = this.ssDisplayName;
t.ssJobTitle = this.ssJobTitle;
t.ssIsNotMapped = this.ssIsNotMapped;
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
if (head == "displayname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DisplayName")) variable.Value = ssDisplayName; else variable.Optimized = true;
} else if (head == "jobtitle") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".JobTitle")) variable.Value = ssJobTitle; else variable.Optimized = true;
} else if (head == "isnotmapped") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsNotMapped")) variable.Value = ssIsNotMapped; else variable.Optimized = true;
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
if (key == IdDisplayName) {
return ssDisplayName;
}
if (key == IdJobTitle) {
return ssJobTitle;
}
if (key == IdIsNotMapped) {
return ssIsNotMapped;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDisplayName.Key.AsGuid) {
return ssDisplayName;
}
if (attributeKey == IdJobTitle.Key.AsGuid) {
return ssJobTitle;
}
if (attributeKey == IdIsNotMapped.Key.AsGuid) {
return ssIsNotMapped;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssDisplayName = (string) other.AttributeGet(IdDisplayName);
ssJobTitle = (string) other.AttributeGet(IdJobTitle);
ssIsNotMapped = (bool) other.AttributeGet(IdIsNotMapped);
}
} // RC_2dabb9c9cbdbc6ba6572314572d54c39
/// <summary>
/// RecordList type <code>DisplayNameJobTitleIsNotMappedRecordList</code> that represents a record list
///  of <code>Text, Text, Boolean</code>
/// </summary>
public partial class RL_d8fd32f99db779d312575aee27a70835 : GenericRecordList<RC_2dabb9c9cbdbc6ba6572314572d54c39>, IEnumerable, IEnumerator {

protected override RC_2dabb9c9cbdbc6ba6572314572d54c39 GetElementDefaultValue() {
return new RC_2dabb9c9cbdbc6ba6572314572d54c39();
}

public T[] ToArray<T>(Func<RC_2dabb9c9cbdbc6ba6572314572d54c39, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d8fd32f99db779d312575aee27a70835 recordList, Func<RC_2dabb9c9cbdbc6ba6572314572d54c39, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d8fd32f99db779d312575aee27a70835(RC_2dabb9c9cbdbc6ba6572314572d54c39[] array) {
  RL_d8fd32f99db779d312575aee27a70835 result = new RL_d8fd32f99db779d312575aee27a70835();
result.InnerFromArray(array);
    return result;
}

public static RL_d8fd32f99db779d312575aee27a70835 ToList<T>(T[] array, Func <T, RC_2dabb9c9cbdbc6ba6572314572d54c39> converter) {
  RL_d8fd32f99db779d312575aee27a70835 result = new RL_d8fd32f99db779d312575aee27a70835();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d8fd32f99db779d312575aee27a70835 FromRestList<T>(RestList<T> restList, Func <T, RC_2dabb9c9cbdbc6ba6572314572d54c39> converter) {
  RL_d8fd32f99db779d312575aee27a70835 result = new RL_d8fd32f99db779d312575aee27a70835();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d8fd32f99db779d312575aee27a70835() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_2dabb9c9cbdbc6ba6572314572d54c39> NewList() {
return new RL_d8fd32f99db779d312575aee27a70835();
}


} // RL_d8fd32f99db779d312575aee27a70835
}

