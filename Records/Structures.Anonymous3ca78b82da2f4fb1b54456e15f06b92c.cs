namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (gounPC_asU+1RFbhXwa5LA)
///  <code>RC_f677954b3254ea60260cb7baa72dce4f</code> that represents <code>SustainabilityRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: SustainabilityRecord
public partial struct RC_f677954b3254ea60260cb7baa72dce4f : ITypedRecord<RC_f677954b3254ea60260cb7baa72dce4f> {
internal static readonly GlobalObjectKey IdSustainability = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*S5V39lQyYOomDLe6py3OTw");

public EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord ssENSustainability;


public static implicit operator EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord( RC_f677954b3254ea60260cb7baa72dce4f r) {
return r.ssENSustainability;
}

public static implicit operator RC_f677954b3254ea60260cb7baa72dce4f (EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord r) {
RC_f677954b3254ea60260cb7baa72dce4f res = new RC_f677954b3254ea60260cb7baa72dce4f ();
res.ssENSustainability = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENSustainability.ChangedAttributes = value;
}
get {
    return ssENSustainability.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_f677954b3254ea60260cb7baa72dce4f() {
OptimizedAttributes = null;
ssENSustainability = new EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENSustainability.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENSustainability.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENSustainability.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENSustainability.Read( r, ref index);
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
public void ReadIM(RC_f677954b3254ea60260cb7baa72dce4f r) {
this = r;
}


public static bool operator == (RC_f677954b3254ea60260cb7baa72dce4f a, RC_f677954b3254ea60260cb7baa72dce4f b) {
if (a.ssENSustainability != b.ssENSustainability) return false;
return true;
}

public static bool operator != (RC_f677954b3254ea60260cb7baa72dce4f a, RC_f677954b3254ea60260cb7baa72dce4f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f677954b3254ea60260cb7baa72dce4f)) return false;
return (this == (RC_f677954b3254ea60260cb7baa72dce4f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENSustainability.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENSustainability.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENSustainability.InternalRecursiveSave();
}


public RC_f677954b3254ea60260cb7baa72dce4f Duplicate() {
RC_f677954b3254ea60260cb7baa72dce4f t;
t.ssENSustainability = (EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord)this.ssENSustainability.Duplicate();
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
if (head == "sustainability") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Sustainability")) variable.Value = ssENSustainability; else variable.Optimized = true;
variable.SetFieldName("sustainability");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENSustainability.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENSustainability.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdSustainability) {
return ssENSustainability;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSustainability.Key.AsGuid) {
return ssENSustainability;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENSustainability.FillFromOther((IRecord) other.AttributeGet(IdSustainability));
}
} // RC_f677954b3254ea60260cb7baa72dce4f
/// <summary>
/// RecordList type <code>SustainabilityRecordList</code> that represents a record list of
///  <code>Sustainability</code>
/// </summary>
public partial class RL_c861661ffef6a96c498651ed1efeee53 : GenericRecordList<RC_f677954b3254ea60260cb7baa72dce4f>, IEnumerable, IEnumerator {

protected override RC_f677954b3254ea60260cb7baa72dce4f GetElementDefaultValue() {
return new RC_f677954b3254ea60260cb7baa72dce4f();
}

public T[] ToArray<T>(Func<RC_f677954b3254ea60260cb7baa72dce4f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c861661ffef6a96c498651ed1efeee53 recordList, Func<RC_f677954b3254ea60260cb7baa72dce4f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c861661ffef6a96c498651ed1efeee53(RC_f677954b3254ea60260cb7baa72dce4f[] array) {
  RL_c861661ffef6a96c498651ed1efeee53 result = new RL_c861661ffef6a96c498651ed1efeee53();
result.InnerFromArray(array);
    return result;
}

public static RL_c861661ffef6a96c498651ed1efeee53 ToList<T>(T[] array, Func <T, RC_f677954b3254ea60260cb7baa72dce4f> converter) {
  RL_c861661ffef6a96c498651ed1efeee53 result = new RL_c861661ffef6a96c498651ed1efeee53();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c861661ffef6a96c498651ed1efeee53 FromRestList<T>(RestList<T> restList, Func <T, RC_f677954b3254ea60260cb7baa72dce4f> converter) {
  RL_c861661ffef6a96c498651ed1efeee53 result = new RL_c861661ffef6a96c498651ed1efeee53();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c861661ffef6a96c498651ed1efeee53() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_f677954b3254ea60260cb7baa72dce4f> NewList() {
return new RL_c861661ffef6a96c498651ed1efeee53();
}


} // RL_c861661ffef6a96c498651ed1efeee53
}

