namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (WZol8SSKwk+setoySwgsBQ)
///  <code>RC_73d8126c722e2b4dd662dab2bf1a72d1</code> that represent
/// s <code>OrderRequestFileRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderRequestFileRecord
public partial struct RC_73d8126c722e2b4dd662dab2bf1a72d1 : ITypedRecord<RC_73d8126c722e2b4dd662dab2bf1a72d1> {
internal static readonly GlobalObjectKey IdOrderRequestFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bBLYcy5yTSvWYtqyvxpy0Q");

public EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord ssENOrderRequestFile;


public static implicit operator EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord( RC_73d8126c722e2b4dd662dab2bf1a72d1 r) {
return r.ssENOrderRequestFile;
}

public static implicit operator RC_73d8126c722e2b4dd662dab2bf1a72d1 (EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord r) {
RC_73d8126c722e2b4dd662dab2bf1a72d1 res = new RC_73d8126c722e2b4dd662dab2bf1a72d1 ();
res.ssENOrderRequestFile = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENOrderRequestFile.ChangedAttributes = value;
}
get {
    return ssENOrderRequestFile.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_73d8126c722e2b4dd662dab2bf1a72d1() {
OptimizedAttributes = null;
ssENOrderRequestFile = new EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(17,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderRequestFile.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENOrderRequestFile.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENOrderRequestFile.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderRequestFile.Read( r, ref index);
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
public void ReadIM(RC_73d8126c722e2b4dd662dab2bf1a72d1 r) {
this = r;
}


public static bool operator == (RC_73d8126c722e2b4dd662dab2bf1a72d1 a, RC_73d8126c722e2b4dd662dab2bf1a72d1 b) {
if (a.ssENOrderRequestFile != b.ssENOrderRequestFile) return false;
return true;
}

public static bool operator != (RC_73d8126c722e2b4dd662dab2bf1a72d1 a, RC_73d8126c722e2b4dd662dab2bf1a72d1 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_73d8126c722e2b4dd662dab2bf1a72d1)) return false;
return (this == (RC_73d8126c722e2b4dd662dab2bf1a72d1)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderRequestFile.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderRequestFile.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderRequestFile.InternalRecursiveSave();
}


public RC_73d8126c722e2b4dd662dab2bf1a72d1 Duplicate() {
RC_73d8126c722e2b4dd662dab2bf1a72d1 t;
t.ssENOrderRequestFile = (EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord)this.ssENOrderRequestFile.Duplicate();
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
if (head == "orderrequestfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderRequestFile")) variable.Value = ssENOrderRequestFile; else variable.Optimized = true;
variable.SetFieldName("orderrequestfile");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENOrderRequestFile.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENOrderRequestFile.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdOrderRequestFile) {
return ssENOrderRequestFile;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderRequestFile.Key.AsGuid) {
return ssENOrderRequestFile;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderRequestFile.FillFromOther((IRecord) other.AttributeGet(IdOrderRequestFile));
}
} // RC_73d8126c722e2b4dd662dab2bf1a72d1
/// <summary>
/// RecordList type <code>OrderRequestFileRecordList</code> that represents a record list of
///  <code>OrderRequestFile</code>
/// </summary>
public partial class RL_d258c3d50d870257794347fdeb7cc218 : GenericRecordList<RC_73d8126c722e2b4dd662dab2bf1a72d1>, IEnumerable, IEnumerator {

protected override RC_73d8126c722e2b4dd662dab2bf1a72d1 GetElementDefaultValue() {
return new RC_73d8126c722e2b4dd662dab2bf1a72d1();
}

public T[] ToArray<T>(Func<RC_73d8126c722e2b4dd662dab2bf1a72d1, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d258c3d50d870257794347fdeb7cc218 recordList, Func<RC_73d8126c722e2b4dd662dab2bf1a72d1, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d258c3d50d870257794347fdeb7cc218(RC_73d8126c722e2b4dd662dab2bf1a72d1[] array) {
  RL_d258c3d50d870257794347fdeb7cc218 result = new RL_d258c3d50d870257794347fdeb7cc218();
result.InnerFromArray(array);
    return result;
}

public static RL_d258c3d50d870257794347fdeb7cc218 ToList<T>(T[] array, Func <T, RC_73d8126c722e2b4dd662dab2bf1a72d1> converter) {
  RL_d258c3d50d870257794347fdeb7cc218 result = new RL_d258c3d50d870257794347fdeb7cc218();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d258c3d50d870257794347fdeb7cc218 FromRestList<T>(RestList<T> restList, Func <T, RC_73d8126c722e2b4dd662dab2bf1a72d1> converter) {
  RL_d258c3d50d870257794347fdeb7cc218 result = new RL_d258c3d50d870257794347fdeb7cc218();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d258c3d50d870257794347fdeb7cc218() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(17,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_73d8126c722e2b4dd662dab2bf1a72d1> NewList() {
return new RL_d258c3d50d870257794347fdeb7cc218();
}


} // RL_d258c3d50d870257794347fdeb7cc218
}

