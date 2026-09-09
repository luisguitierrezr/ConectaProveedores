namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (302nMMboBEukYa5PzC1fXw)
///  <code>RC_250abb7806127d6d6c565bcd6bd8fd6f</code> that represents <code>LegendLayoutRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: LegendLayoutRecord
public partial struct RC_250abb7806127d6d6c565bcd6bd8fd6f : ITypedRecord<RC_250abb7806127d6d6c565bcd6bd8fd6f> {
internal static readonly GlobalObjectKey IdLegendLayout = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*eLsKJRIGbX1sVlvNa9j9bw");

public EN_f2ce8f552d142202c9a955104f8986e7EntityRecord ssENLegendLayout;


public static implicit operator EN_f2ce8f552d142202c9a955104f8986e7EntityRecord( RC_250abb7806127d6d6c565bcd6bd8fd6f r) {
return r.ssENLegendLayout;
}

public static implicit operator RC_250abb7806127d6d6c565bcd6bd8fd6f (EN_f2ce8f552d142202c9a955104f8986e7EntityRecord r) {
RC_250abb7806127d6d6c565bcd6bd8fd6f res = new RC_250abb7806127d6d6c565bcd6bd8fd6f ();
res.ssENLegendLayout = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENLegendLayout.ChangedAttributes = value;
}
get {
    return ssENLegendLayout.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_250abb7806127d6d6c565bcd6bd8fd6f() {
OptimizedAttributes = null;
ssENLegendLayout = new EN_f2ce8f552d142202c9a955104f8986e7EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENLegendLayout.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENLegendLayout.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENLegendLayout.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENLegendLayout.Read( r, ref index);
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
public void ReadIM(RC_250abb7806127d6d6c565bcd6bd8fd6f r) {
this = r;
}


public static bool operator == (RC_250abb7806127d6d6c565bcd6bd8fd6f a, RC_250abb7806127d6d6c565bcd6bd8fd6f b) {
if (a.ssENLegendLayout != b.ssENLegendLayout) return false;
return true;
}

public static bool operator != (RC_250abb7806127d6d6c565bcd6bd8fd6f a, RC_250abb7806127d6d6c565bcd6bd8fd6f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_250abb7806127d6d6c565bcd6bd8fd6f)) return false;
return (this == (RC_250abb7806127d6d6c565bcd6bd8fd6f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENLegendLayout.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENLegendLayout.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENLegendLayout.InternalRecursiveSave();
}


public RC_250abb7806127d6d6c565bcd6bd8fd6f Duplicate() {
RC_250abb7806127d6d6c565bcd6bd8fd6f t;
t.ssENLegendLayout = (EN_f2ce8f552d142202c9a955104f8986e7EntityRecord)this.ssENLegendLayout.Duplicate();
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
if (head == "legendlayout") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LegendLayout")) variable.Value = ssENLegendLayout; else variable.Optimized = true;
variable.SetFieldName("legendlayout");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENLegendLayout.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENLegendLayout.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdLegendLayout) {
return ssENLegendLayout;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdLegendLayout.Key.AsGuid) {
return ssENLegendLayout;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENLegendLayout.FillFromOther((IRecord) other.AttributeGet(IdLegendLayout));
}
} // RC_250abb7806127d6d6c565bcd6bd8fd6f
/// <summary>
/// RecordList type <code>LegendLayoutRecordList</code> that represents a record list of
///  <code>LegendLayout</code>
/// </summary>
public partial class RL_2c26fb87fc1f13f5c33922f9f936d791 : GenericRecordList<RC_250abb7806127d6d6c565bcd6bd8fd6f>, IEnumerable, IEnumerator {

protected override RC_250abb7806127d6d6c565bcd6bd8fd6f GetElementDefaultValue() {
return new RC_250abb7806127d6d6c565bcd6bd8fd6f();
}

public T[] ToArray<T>(Func<RC_250abb7806127d6d6c565bcd6bd8fd6f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2c26fb87fc1f13f5c33922f9f936d791 recordList, Func<RC_250abb7806127d6d6c565bcd6bd8fd6f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2c26fb87fc1f13f5c33922f9f936d791(RC_250abb7806127d6d6c565bcd6bd8fd6f[] array) {
  RL_2c26fb87fc1f13f5c33922f9f936d791 result = new RL_2c26fb87fc1f13f5c33922f9f936d791();
result.InnerFromArray(array);
    return result;
}

public static RL_2c26fb87fc1f13f5c33922f9f936d791 ToList<T>(T[] array, Func <T, RC_250abb7806127d6d6c565bcd6bd8fd6f> converter) {
  RL_2c26fb87fc1f13f5c33922f9f936d791 result = new RL_2c26fb87fc1f13f5c33922f9f936d791();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2c26fb87fc1f13f5c33922f9f936d791 FromRestList<T>(RestList<T> restList, Func <T, RC_250abb7806127d6d6c565bcd6bd8fd6f> converter) {
  RL_2c26fb87fc1f13f5c33922f9f936d791 result = new RL_2c26fb87fc1f13f5c33922f9f936d791();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2c26fb87fc1f13f5c33922f9f936d791() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(1,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_250abb7806127d6d6c565bcd6bd8fd6f> NewList() {
return new RL_2c26fb87fc1f13f5c33922f9f936d791();
}


} // RL_2c26fb87fc1f13f5c33922f9f936d791
}

