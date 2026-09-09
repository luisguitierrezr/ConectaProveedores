namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (Eu_BUsJz1E+I73tvwUgS7w)
///  <code>RC_3d7c5be4055c8fe2c227afc40d8dee2f</code> that represents <code>ScrollbarStyleRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ScrollbarStyleRecord
public partial struct RC_3d7c5be4055c8fe2c227afc40d8dee2f : ITypedRecord<RC_3d7c5be4055c8fe2c227afc40d8dee2f> {
internal static readonly GlobalObjectKey IdScrollbarStyle = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*5Ft8PVwF4o_CJ6_EDY3uLw");

public EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord ssENScrollbarStyle;


public static implicit operator EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord( RC_3d7c5be4055c8fe2c227afc40d8dee2f r) {
return r.ssENScrollbarStyle;
}

public static implicit operator RC_3d7c5be4055c8fe2c227afc40d8dee2f (EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord r) {
RC_3d7c5be4055c8fe2c227afc40d8dee2f res = new RC_3d7c5be4055c8fe2c227afc40d8dee2f ();
res.ssENScrollbarStyle = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENScrollbarStyle.ChangedAttributes = value;
}
get {
    return ssENScrollbarStyle.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_3d7c5be4055c8fe2c227afc40d8dee2f() {
OptimizedAttributes = null;
ssENScrollbarStyle = new EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENScrollbarStyle.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENScrollbarStyle.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENScrollbarStyle.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENScrollbarStyle.Read( r, ref index);
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
public void ReadIM(RC_3d7c5be4055c8fe2c227afc40d8dee2f r) {
this = r;
}


public static bool operator == (RC_3d7c5be4055c8fe2c227afc40d8dee2f a, RC_3d7c5be4055c8fe2c227afc40d8dee2f b) {
if (a.ssENScrollbarStyle != b.ssENScrollbarStyle) return false;
return true;
}

public static bool operator != (RC_3d7c5be4055c8fe2c227afc40d8dee2f a, RC_3d7c5be4055c8fe2c227afc40d8dee2f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3d7c5be4055c8fe2c227afc40d8dee2f)) return false;
return (this == (RC_3d7c5be4055c8fe2c227afc40d8dee2f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENScrollbarStyle.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENScrollbarStyle.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENScrollbarStyle.InternalRecursiveSave();
}


public RC_3d7c5be4055c8fe2c227afc40d8dee2f Duplicate() {
RC_3d7c5be4055c8fe2c227afc40d8dee2f t;
t.ssENScrollbarStyle = (EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord)this.ssENScrollbarStyle.Duplicate();
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
if (head == "scrollbarstyle") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ScrollbarStyle")) variable.Value = ssENScrollbarStyle; else variable.Optimized = true;
variable.SetFieldName("scrollbarstyle");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENScrollbarStyle.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENScrollbarStyle.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdScrollbarStyle) {
return ssENScrollbarStyle;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdScrollbarStyle.Key.AsGuid) {
return ssENScrollbarStyle;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENScrollbarStyle.FillFromOther((IRecord) other.AttributeGet(IdScrollbarStyle));
}
} // RC_3d7c5be4055c8fe2c227afc40d8dee2f
/// <summary>
/// RecordList type <code>ScrollbarStyleRecordList</code> that represents a record list of
///  <code>ScrollbarStyle</code>
/// </summary>
public partial class RL_ff5ba20b0d42d4170d7b63779346dc5d : GenericRecordList<RC_3d7c5be4055c8fe2c227afc40d8dee2f>, IEnumerable, IEnumerator {

protected override RC_3d7c5be4055c8fe2c227afc40d8dee2f GetElementDefaultValue() {
return new RC_3d7c5be4055c8fe2c227afc40d8dee2f();
}

public T[] ToArray<T>(Func<RC_3d7c5be4055c8fe2c227afc40d8dee2f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ff5ba20b0d42d4170d7b63779346dc5d recordList, Func<RC_3d7c5be4055c8fe2c227afc40d8dee2f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ff5ba20b0d42d4170d7b63779346dc5d(RC_3d7c5be4055c8fe2c227afc40d8dee2f[] array) {
  RL_ff5ba20b0d42d4170d7b63779346dc5d result = new RL_ff5ba20b0d42d4170d7b63779346dc5d();
result.InnerFromArray(array);
    return result;
}

public static RL_ff5ba20b0d42d4170d7b63779346dc5d ToList<T>(T[] array, Func <T, RC_3d7c5be4055c8fe2c227afc40d8dee2f> converter) {
  RL_ff5ba20b0d42d4170d7b63779346dc5d result = new RL_ff5ba20b0d42d4170d7b63779346dc5d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ff5ba20b0d42d4170d7b63779346dc5d FromRestList<T>(RestList<T> restList, Func <T, RC_3d7c5be4055c8fe2c227afc40d8dee2f> converter) {
  RL_ff5ba20b0d42d4170d7b63779346dc5d result = new RL_ff5ba20b0d42d4170d7b63779346dc5d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ff5ba20b0d42d4170d7b63779346dc5d() : base() {
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
protected override OSList<RC_3d7c5be4055c8fe2c227afc40d8dee2f> NewList() {
return new RL_ff5ba20b0d42d4170d7b63779346dc5d();
}


} // RL_ff5ba20b0d42d4170d7b63779346dc5d
}

