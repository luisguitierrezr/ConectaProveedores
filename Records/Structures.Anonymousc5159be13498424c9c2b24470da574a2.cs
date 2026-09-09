namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (4ZsVxZg0TEKcKyRHDaV0og)
///  <code>RC_c808f777f2a76c70ea9a3f0e560c6a3b</code> that represent
/// s <code>ProcessTypeDatesAllowedRecord</code> <p>Description: </p>
/// </summary>
// Name: ProcessTypeDatesAllowedRecord
public partial struct RC_c808f777f2a76c70ea9a3f0e560c6a3b : ITypedRecord<RC_c808f777f2a76c70ea9a3f0e560c6a3b> {
internal static readonly GlobalObjectKey IdProcessTypeDatesAllowed = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*d_cIyKfycGzqmj8OVgxqOw");

public EN_280cfaefc7654494be27c153014e657dEntityRecord ssENProcessTypeDatesAllowed;


public static implicit operator EN_280cfaefc7654494be27c153014e657dEntityRecord( RC_c808f777f2a76c70ea9a3f0e560c6a3b r) {
return r.ssENProcessTypeDatesAllowed;
}

public static implicit operator RC_c808f777f2a76c70ea9a3f0e560c6a3b (EN_280cfaefc7654494be27c153014e657dEntityRecord r) {
RC_c808f777f2a76c70ea9a3f0e560c6a3b res = new RC_c808f777f2a76c70ea9a3f0e560c6a3b ();
res.ssENProcessTypeDatesAllowed = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENProcessTypeDatesAllowed.ChangedAttributes = value;
}
get {
    return ssENProcessTypeDatesAllowed.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_c808f777f2a76c70ea9a3f0e560c6a3b() {
OptimizedAttributes = null;
ssENProcessTypeDatesAllowed = new EN_280cfaefc7654494be27c153014e657dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProcessTypeDatesAllowed.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENProcessTypeDatesAllowed.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENProcessTypeDatesAllowed.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENProcessTypeDatesAllowed.Read( r, ref index);
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
public void ReadIM(RC_c808f777f2a76c70ea9a3f0e560c6a3b r) {
this = r;
}


public static bool operator == (RC_c808f777f2a76c70ea9a3f0e560c6a3b a, RC_c808f777f2a76c70ea9a3f0e560c6a3b b) {
if (a.ssENProcessTypeDatesAllowed != b.ssENProcessTypeDatesAllowed) return false;
return true;
}

public static bool operator != (RC_c808f777f2a76c70ea9a3f0e560c6a3b a, RC_c808f777f2a76c70ea9a3f0e560c6a3b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c808f777f2a76c70ea9a3f0e560c6a3b)) return false;
return (this == (RC_c808f777f2a76c70ea9a3f0e560c6a3b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProcessTypeDatesAllowed.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProcessTypeDatesAllowed.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProcessTypeDatesAllowed.InternalRecursiveSave();
}


public RC_c808f777f2a76c70ea9a3f0e560c6a3b Duplicate() {
RC_c808f777f2a76c70ea9a3f0e560c6a3b t;
t.ssENProcessTypeDatesAllowed = (EN_280cfaefc7654494be27c153014e657dEntityRecord)this.ssENProcessTypeDatesAllowed.Duplicate();
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
if (head == "processtypedatesallowed") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProcessTypeDatesAllowed")) variable.Value = ssENProcessTypeDatesAllowed; else variable.Optimized = true;
variable.SetFieldName("processtypedatesallowed");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENProcessTypeDatesAllowed.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENProcessTypeDatesAllowed.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdProcessTypeDatesAllowed) {
return ssENProcessTypeDatesAllowed;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProcessTypeDatesAllowed.Key.AsGuid) {
return ssENProcessTypeDatesAllowed;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProcessTypeDatesAllowed.FillFromOther((IRecord) other.AttributeGet(IdProcessTypeDatesAllowed));
}
} // RC_c808f777f2a76c70ea9a3f0e560c6a3b
/// <summary>
/// RecordList type <code>ProcessTypeDatesAllowedRecordList</code> that represents a record list of
///  <code>ProcessTypeDatesAllowed</code>
/// </summary>
public partial class RL_f1cff35b44b1219a5762b1a0f06890af : GenericRecordList<RC_c808f777f2a76c70ea9a3f0e560c6a3b>, IEnumerable, IEnumerator {

protected override RC_c808f777f2a76c70ea9a3f0e560c6a3b GetElementDefaultValue() {
return new RC_c808f777f2a76c70ea9a3f0e560c6a3b();
}

public T[] ToArray<T>(Func<RC_c808f777f2a76c70ea9a3f0e560c6a3b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f1cff35b44b1219a5762b1a0f06890af recordList, Func<RC_c808f777f2a76c70ea9a3f0e560c6a3b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f1cff35b44b1219a5762b1a0f06890af(RC_c808f777f2a76c70ea9a3f0e560c6a3b[] array) {
  RL_f1cff35b44b1219a5762b1a0f06890af result = new RL_f1cff35b44b1219a5762b1a0f06890af();
result.InnerFromArray(array);
    return result;
}

public static RL_f1cff35b44b1219a5762b1a0f06890af ToList<T>(T[] array, Func <T, RC_c808f777f2a76c70ea9a3f0e560c6a3b> converter) {
  RL_f1cff35b44b1219a5762b1a0f06890af result = new RL_f1cff35b44b1219a5762b1a0f06890af();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f1cff35b44b1219a5762b1a0f06890af FromRestList<T>(RestList<T> restList, Func <T, RC_c808f777f2a76c70ea9a3f0e560c6a3b> converter) {
  RL_f1cff35b44b1219a5762b1a0f06890af result = new RL_f1cff35b44b1219a5762b1a0f06890af();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f1cff35b44b1219a5762b1a0f06890af() : base() {
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
protected override OSList<RC_c808f777f2a76c70ea9a3f0e560c6a3b> NewList() {
return new RL_f1cff35b44b1219a5762b1a0f06890af();
}


} // RL_f1cff35b44b1219a5762b1a0f06890af
}

