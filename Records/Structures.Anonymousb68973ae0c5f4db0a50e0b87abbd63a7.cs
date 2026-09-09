namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (rnOJtl8MsE2lDguHq71jpw)
///  <code>RC_017cba02e4fd7f684606081b7269a26b</code> that represent
/// s <code>FolioObservationsRecord</code> <p>Description: </p>
/// </summary>
// Name: FolioObservationsRecord
public partial struct RC_017cba02e4fd7f684606081b7269a26b : ITypedRecord<RC_017cba02e4fd7f684606081b7269a26b> {
internal static readonly GlobalObjectKey IdFolioObservations = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Arp8Af3kaH9GBggbcmmiaw");

public EN_171b22187ea6e4b12c9f086502740307EntityRecord ssENFolioObservations;


public static implicit operator EN_171b22187ea6e4b12c9f086502740307EntityRecord( RC_017cba02e4fd7f684606081b7269a26b r) {
return r.ssENFolioObservations;
}

public static implicit operator RC_017cba02e4fd7f684606081b7269a26b (EN_171b22187ea6e4b12c9f086502740307EntityRecord r) {
RC_017cba02e4fd7f684606081b7269a26b res = new RC_017cba02e4fd7f684606081b7269a26b ();
res.ssENFolioObservations = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENFolioObservations.ChangedAttributes = value;
}
get {
    return ssENFolioObservations.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_017cba02e4fd7f684606081b7269a26b() {
OptimizedAttributes = null;
ssENFolioObservations = new EN_171b22187ea6e4b12c9f086502740307EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolioObservations.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENFolioObservations.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENFolioObservations.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFolioObservations.Read( r, ref index);
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
public void ReadIM(RC_017cba02e4fd7f684606081b7269a26b r) {
this = r;
}


public static bool operator == (RC_017cba02e4fd7f684606081b7269a26b a, RC_017cba02e4fd7f684606081b7269a26b b) {
if (a.ssENFolioObservations != b.ssENFolioObservations) return false;
return true;
}

public static bool operator != (RC_017cba02e4fd7f684606081b7269a26b a, RC_017cba02e4fd7f684606081b7269a26b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_017cba02e4fd7f684606081b7269a26b)) return false;
return (this == (RC_017cba02e4fd7f684606081b7269a26b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolioObservations.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolioObservations.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolioObservations.InternalRecursiveSave();
}


public RC_017cba02e4fd7f684606081b7269a26b Duplicate() {
RC_017cba02e4fd7f684606081b7269a26b t;
t.ssENFolioObservations = (EN_171b22187ea6e4b12c9f086502740307EntityRecord)this.ssENFolioObservations.Duplicate();
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
if (head == "folioobservations") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioObservations")) variable.Value = ssENFolioObservations; else variable.Optimized = true;
variable.SetFieldName("folioobservations");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENFolioObservations.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENFolioObservations.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdFolioObservations) {
return ssENFolioObservations;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolioObservations.Key.AsGuid) {
return ssENFolioObservations;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFolioObservations.FillFromOther((IRecord) other.AttributeGet(IdFolioObservations));
}
} // RC_017cba02e4fd7f684606081b7269a26b
/// <summary>
/// RecordList type <code>FolioObservationsRecordList</code> that represents a record list of
///  <code>FolioObservations</code>
/// </summary>
public partial class RL_994583bfe1c92160ce9fe58b4f4e0d70 : GenericRecordList<RC_017cba02e4fd7f684606081b7269a26b>, IEnumerable, IEnumerator {

protected override RC_017cba02e4fd7f684606081b7269a26b GetElementDefaultValue() {
return new RC_017cba02e4fd7f684606081b7269a26b();
}

public T[] ToArray<T>(Func<RC_017cba02e4fd7f684606081b7269a26b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_994583bfe1c92160ce9fe58b4f4e0d70 recordList, Func<RC_017cba02e4fd7f684606081b7269a26b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_994583bfe1c92160ce9fe58b4f4e0d70(RC_017cba02e4fd7f684606081b7269a26b[] array) {
  RL_994583bfe1c92160ce9fe58b4f4e0d70 result = new RL_994583bfe1c92160ce9fe58b4f4e0d70();
result.InnerFromArray(array);
    return result;
}

public static RL_994583bfe1c92160ce9fe58b4f4e0d70 ToList<T>(T[] array, Func <T, RC_017cba02e4fd7f684606081b7269a26b> converter) {
  RL_994583bfe1c92160ce9fe58b4f4e0d70 result = new RL_994583bfe1c92160ce9fe58b4f4e0d70();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_994583bfe1c92160ce9fe58b4f4e0d70 FromRestList<T>(RestList<T> restList, Func <T, RC_017cba02e4fd7f684606081b7269a26b> converter) {
  RL_994583bfe1c92160ce9fe58b4f4e0d70 result = new RL_994583bfe1c92160ce9fe58b4f4e0d70();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_994583bfe1c92160ce9fe58b4f4e0d70() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_017cba02e4fd7f684606081b7269a26b> NewList() {
return new RL_994583bfe1c92160ce9fe58b4f4e0d70();
}


} // RL_994583bfe1c92160ce9fe58b4f4e0d70
}

