namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (3YZMIWi_VkiULCvnfkaoZw)
///  <code>RC_5a839548c2b6676209dad9fb179bc76c</code> that represents <code>ManualsRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ManualsRecord
public partial struct RC_5a839548c2b6676209dad9fb179bc76c : ITypedRecord<RC_5a839548c2b6676209dad9fb179bc76c> {
internal static readonly GlobalObjectKey IdManuals = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SJWDWrbCYmcJ2tn7F5vHbA");

public EN_f9557b941e05ea8155a182da4f23a896EntityRecord ssENManuals;


public static implicit operator EN_f9557b941e05ea8155a182da4f23a896EntityRecord( RC_5a839548c2b6676209dad9fb179bc76c r) {
return r.ssENManuals;
}

public static implicit operator RC_5a839548c2b6676209dad9fb179bc76c (EN_f9557b941e05ea8155a182da4f23a896EntityRecord r) {
RC_5a839548c2b6676209dad9fb179bc76c res = new RC_5a839548c2b6676209dad9fb179bc76c ();
res.ssENManuals = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENManuals.ChangedAttributes = value;
}
get {
    return ssENManuals.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_5a839548c2b6676209dad9fb179bc76c() {
OptimizedAttributes = null;
ssENManuals = new EN_f9557b941e05ea8155a182da4f23a896EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(12,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENManuals.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENManuals.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENManuals.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENManuals.Read( r, ref index);
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
public void ReadIM(RC_5a839548c2b6676209dad9fb179bc76c r) {
this = r;
}


public static bool operator == (RC_5a839548c2b6676209dad9fb179bc76c a, RC_5a839548c2b6676209dad9fb179bc76c b) {
if (a.ssENManuals != b.ssENManuals) return false;
return true;
}

public static bool operator != (RC_5a839548c2b6676209dad9fb179bc76c a, RC_5a839548c2b6676209dad9fb179bc76c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_5a839548c2b6676209dad9fb179bc76c)) return false;
return (this == (RC_5a839548c2b6676209dad9fb179bc76c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENManuals.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENManuals.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENManuals.InternalRecursiveSave();
}


public RC_5a839548c2b6676209dad9fb179bc76c Duplicate() {
RC_5a839548c2b6676209dad9fb179bc76c t;
t.ssENManuals = (EN_f9557b941e05ea8155a182da4f23a896EntityRecord)this.ssENManuals.Duplicate();
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
if (head == "manuals") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Manuals")) variable.Value = ssENManuals; else variable.Optimized = true;
variable.SetFieldName("manuals");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENManuals.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENManuals.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdManuals) {
return ssENManuals;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdManuals.Key.AsGuid) {
return ssENManuals;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENManuals.FillFromOther((IRecord) other.AttributeGet(IdManuals));
}
} // RC_5a839548c2b6676209dad9fb179bc76c
/// <summary>
/// RecordList type <code>ManualsRecordList</code> that represents a record list of
///  <code>Manuals</code>
/// </summary>
public partial class RL_f115f48f5d8f8bcc5c52de41692117a1 : GenericRecordList<RC_5a839548c2b6676209dad9fb179bc76c>, IEnumerable, IEnumerator {

protected override RC_5a839548c2b6676209dad9fb179bc76c GetElementDefaultValue() {
return new RC_5a839548c2b6676209dad9fb179bc76c();
}

public T[] ToArray<T>(Func<RC_5a839548c2b6676209dad9fb179bc76c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f115f48f5d8f8bcc5c52de41692117a1 recordList, Func<RC_5a839548c2b6676209dad9fb179bc76c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f115f48f5d8f8bcc5c52de41692117a1(RC_5a839548c2b6676209dad9fb179bc76c[] array) {
  RL_f115f48f5d8f8bcc5c52de41692117a1 result = new RL_f115f48f5d8f8bcc5c52de41692117a1();
result.InnerFromArray(array);
    return result;
}

public static RL_f115f48f5d8f8bcc5c52de41692117a1 ToList<T>(T[] array, Func <T, RC_5a839548c2b6676209dad9fb179bc76c> converter) {
  RL_f115f48f5d8f8bcc5c52de41692117a1 result = new RL_f115f48f5d8f8bcc5c52de41692117a1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f115f48f5d8f8bcc5c52de41692117a1 FromRestList<T>(RestList<T> restList, Func <T, RC_5a839548c2b6676209dad9fb179bc76c> converter) {
  RL_f115f48f5d8f8bcc5c52de41692117a1 result = new RL_f115f48f5d8f8bcc5c52de41692117a1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f115f48f5d8f8bcc5c52de41692117a1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(12,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_5a839548c2b6676209dad9fb179bc76c> NewList() {
return new RL_f115f48f5d8f8bcc5c52de41692117a1();
}


} // RL_f115f48f5d8f8bcc5c52de41692117a1
}

