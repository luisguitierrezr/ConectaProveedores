namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (m6BOCJcVRUybzNgJ0VUvfw)
///  <code>RC_a5018402fa6c90c5e826e54b2748cedc</code> that represents <code>GutterSizeRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: GutterSizeRecord
public partial struct RC_a5018402fa6c90c5e826e54b2748cedc : ITypedRecord<RC_a5018402fa6c90c5e826e54b2748cedc> {
internal static readonly GlobalObjectKey IdGutterSize = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*AoQBpWz6xZDoJuVLJ0jO3A");

public EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord ssENGutterSize;


public static implicit operator EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord( RC_a5018402fa6c90c5e826e54b2748cedc r) {
return r.ssENGutterSize;
}

public static implicit operator RC_a5018402fa6c90c5e826e54b2748cedc (EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord r) {
RC_a5018402fa6c90c5e826e54b2748cedc res = new RC_a5018402fa6c90c5e826e54b2748cedc ();
res.ssENGutterSize = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENGutterSize.ChangedAttributes = value;
}
get {
    return ssENGutterSize.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_a5018402fa6c90c5e826e54b2748cedc() {
OptimizedAttributes = null;
ssENGutterSize = new EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(2,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENGutterSize.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENGutterSize.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENGutterSize.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENGutterSize.Read( r, ref index);
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
public void ReadIM(RC_a5018402fa6c90c5e826e54b2748cedc r) {
this = r;
}


public static bool operator == (RC_a5018402fa6c90c5e826e54b2748cedc a, RC_a5018402fa6c90c5e826e54b2748cedc b) {
if (a.ssENGutterSize != b.ssENGutterSize) return false;
return true;
}

public static bool operator != (RC_a5018402fa6c90c5e826e54b2748cedc a, RC_a5018402fa6c90c5e826e54b2748cedc b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a5018402fa6c90c5e826e54b2748cedc)) return false;
return (this == (RC_a5018402fa6c90c5e826e54b2748cedc)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENGutterSize.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENGutterSize.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENGutterSize.InternalRecursiveSave();
}


public RC_a5018402fa6c90c5e826e54b2748cedc Duplicate() {
RC_a5018402fa6c90c5e826e54b2748cedc t;
t.ssENGutterSize = (EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord)this.ssENGutterSize.Duplicate();
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
if (head == "guttersize") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".GutterSize")) variable.Value = ssENGutterSize; else variable.Optimized = true;
variable.SetFieldName("guttersize");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENGutterSize.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENGutterSize.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdGutterSize) {
return ssENGutterSize;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdGutterSize.Key.AsGuid) {
return ssENGutterSize;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENGutterSize.FillFromOther((IRecord) other.AttributeGet(IdGutterSize));
}
} // RC_a5018402fa6c90c5e826e54b2748cedc
/// <summary>
/// RecordList type <code>GutterSizeRecordList</code> that represents a record list of
///  <code>GutterSize</code>
/// </summary>
public partial class RL_f115a666c5540eef6697d9968af9fe8e : GenericRecordList<RC_a5018402fa6c90c5e826e54b2748cedc>, IEnumerable, IEnumerator {

protected override RC_a5018402fa6c90c5e826e54b2748cedc GetElementDefaultValue() {
return new RC_a5018402fa6c90c5e826e54b2748cedc();
}

public T[] ToArray<T>(Func<RC_a5018402fa6c90c5e826e54b2748cedc, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f115a666c5540eef6697d9968af9fe8e recordList, Func<RC_a5018402fa6c90c5e826e54b2748cedc, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f115a666c5540eef6697d9968af9fe8e(RC_a5018402fa6c90c5e826e54b2748cedc[] array) {
  RL_f115a666c5540eef6697d9968af9fe8e result = new RL_f115a666c5540eef6697d9968af9fe8e();
result.InnerFromArray(array);
    return result;
}

public static RL_f115a666c5540eef6697d9968af9fe8e ToList<T>(T[] array, Func <T, RC_a5018402fa6c90c5e826e54b2748cedc> converter) {
  RL_f115a666c5540eef6697d9968af9fe8e result = new RL_f115a666c5540eef6697d9968af9fe8e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f115a666c5540eef6697d9968af9fe8e FromRestList<T>(RestList<T> restList, Func <T, RC_a5018402fa6c90c5e826e54b2748cedc> converter) {
  RL_f115a666c5540eef6697d9968af9fe8e result = new RL_f115a666c5540eef6697d9968af9fe8e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f115a666c5540eef6697d9968af9fe8e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(2,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_a5018402fa6c90c5e826e54b2748cedc> NewList() {
return new RL_f115a666c5540eef6697d9968af9fe8e();
}


} // RL_f115a666c5540eef6697d9968af9fe8e
}

