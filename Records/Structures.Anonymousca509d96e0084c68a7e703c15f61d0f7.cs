namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (lp1QygjgaEyn5wPBX2HQ9w)
///  <code>RC_b2bab424cbee127fcb27bb237f9cab05</code> that represents <code>IsBulkShowRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: IsBulkShowRecord
public partial struct RC_b2bab424cbee127fcb27bb237f9cab05 : ITypedRecord<RC_b2bab424cbee127fcb27bb237f9cab05> {
internal static readonly GlobalObjectKey IdIsBulk = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bVvEzreuafOtjw5CFEAtIg");
internal static readonly GlobalObjectKey IdShow = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*2i_zwd_EHhOJa0CVs+vrHQ");

public bool ssIsBulk;

public bool ssShow;


public BitArray OptimizedAttributes;

public RC_b2bab424cbee127fcb27bb237f9cab05() {
OptimizedAttributes = null;
ssIsBulk = false;
ssShow = false;
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
ssIsBulk = r.ReadBoolean(index++, "IsBulkShowRecord.IsBulk", false);
ssShow = r.ReadBoolean(index++, "IsBulkShowRecord.Show", false);
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
public void ReadIM(RC_b2bab424cbee127fcb27bb237f9cab05 r) {
this = r;
}


public static bool operator == (RC_b2bab424cbee127fcb27bb237f9cab05 a, RC_b2bab424cbee127fcb27bb237f9cab05 b) {
if (a.ssIsBulk != b.ssIsBulk) return false;
if (a.ssShow != b.ssShow) return false;
return true;
}

public static bool operator != (RC_b2bab424cbee127fcb27bb237f9cab05 a, RC_b2bab424cbee127fcb27bb237f9cab05 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b2bab424cbee127fcb27bb237f9cab05)) return false;
return (this == (RC_b2bab424cbee127fcb27bb237f9cab05)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssIsBulk.GetHashCode()
 ^ ssShow.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_b2bab424cbee127fcb27bb237f9cab05 Duplicate() {
RC_b2bab424cbee127fcb27bb237f9cab05 t;
t.ssIsBulk = this.ssIsBulk;
t.ssShow = this.ssShow;
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
if (head == "isbulk") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsBulk")) variable.Value = ssIsBulk; else variable.Optimized = true;
} else if (head == "show") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Show")) variable.Value = ssShow; else variable.Optimized = true;
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
if (key == IdIsBulk) {
return ssIsBulk;
}
if (key == IdShow) {
return ssShow;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdIsBulk.Key.AsGuid) {
return ssIsBulk;
}
if (attributeKey == IdShow.Key.AsGuid) {
return ssShow;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssIsBulk = (bool) other.AttributeGet(IdIsBulk);
ssShow = (bool) other.AttributeGet(IdShow);
}
} // RC_b2bab424cbee127fcb27bb237f9cab05
/// <summary>
/// RecordList type <code>IsBulkShowRecordList</code> that represents a record list of <code>Boolean,
///  Boolean</code>
/// </summary>
public partial class RL_c6cef921df92b79509e9baaed60a0826 : GenericRecordList<RC_b2bab424cbee127fcb27bb237f9cab05>, IEnumerable, IEnumerator {

protected override RC_b2bab424cbee127fcb27bb237f9cab05 GetElementDefaultValue() {
return new RC_b2bab424cbee127fcb27bb237f9cab05();
}

public T[] ToArray<T>(Func<RC_b2bab424cbee127fcb27bb237f9cab05, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c6cef921df92b79509e9baaed60a0826 recordList, Func<RC_b2bab424cbee127fcb27bb237f9cab05, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c6cef921df92b79509e9baaed60a0826(RC_b2bab424cbee127fcb27bb237f9cab05[] array) {
  RL_c6cef921df92b79509e9baaed60a0826 result = new RL_c6cef921df92b79509e9baaed60a0826();
result.InnerFromArray(array);
    return result;
}

public static RL_c6cef921df92b79509e9baaed60a0826 ToList<T>(T[] array, Func <T, RC_b2bab424cbee127fcb27bb237f9cab05> converter) {
  RL_c6cef921df92b79509e9baaed60a0826 result = new RL_c6cef921df92b79509e9baaed60a0826();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c6cef921df92b79509e9baaed60a0826 FromRestList<T>(RestList<T> restList, Func <T, RC_b2bab424cbee127fcb27bb237f9cab05> converter) {
  RL_c6cef921df92b79509e9baaed60a0826 result = new RL_c6cef921df92b79509e9baaed60a0826();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c6cef921df92b79509e9baaed60a0826() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_b2bab424cbee127fcb27bb237f9cab05> NewList() {
return new RL_c6cef921df92b79509e9baaed60a0826();
}


} // RL_c6cef921df92b79509e9baaed60a0826
}

