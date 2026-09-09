namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (lkNpE3A7qEGN8x4K2m2tMg)
///  <code>RC_7eea8dd886abe2f5de3217d378b871fd</code> that represent
/// s <code>IVAExceptionM9SuppliersRecord</code> <p>Description: </p>
/// </summary>
// Name: IVAExceptionM9SuppliersRecord
public partial struct RC_7eea8dd886abe2f5de3217d378b871fd : ITypedRecord<RC_7eea8dd886abe2f5de3217d378b871fd> {
internal static readonly GlobalObjectKey IdIVAExceptionM9Suppliers = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*2I3qfquG9eLeMhfTeLhx_Q");

public EN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord ssENIVAExceptionM9Suppliers;


public static implicit operator EN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord( RC_7eea8dd886abe2f5de3217d378b871fd r) {
return r.ssENIVAExceptionM9Suppliers;
}

public static implicit operator RC_7eea8dd886abe2f5de3217d378b871fd (EN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord r) {
RC_7eea8dd886abe2f5de3217d378b871fd res = new RC_7eea8dd886abe2f5de3217d378b871fd ();
res.ssENIVAExceptionM9Suppliers = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENIVAExceptionM9Suppliers.ChangedAttributes = value;
}
get {
    return ssENIVAExceptionM9Suppliers.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_7eea8dd886abe2f5de3217d378b871fd() {
OptimizedAttributes = null;
ssENIVAExceptionM9Suppliers = new EN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(6,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENIVAExceptionM9Suppliers.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENIVAExceptionM9Suppliers.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENIVAExceptionM9Suppliers.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENIVAExceptionM9Suppliers.Read( r, ref index);
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
public void ReadIM(RC_7eea8dd886abe2f5de3217d378b871fd r) {
this = r;
}


public static bool operator == (RC_7eea8dd886abe2f5de3217d378b871fd a, RC_7eea8dd886abe2f5de3217d378b871fd b) {
if (a.ssENIVAExceptionM9Suppliers != b.ssENIVAExceptionM9Suppliers) return false;
return true;
}

public static bool operator != (RC_7eea8dd886abe2f5de3217d378b871fd a, RC_7eea8dd886abe2f5de3217d378b871fd b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_7eea8dd886abe2f5de3217d378b871fd)) return false;
return (this == (RC_7eea8dd886abe2f5de3217d378b871fd)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENIVAExceptionM9Suppliers.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENIVAExceptionM9Suppliers.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENIVAExceptionM9Suppliers.InternalRecursiveSave();
}


public RC_7eea8dd886abe2f5de3217d378b871fd Duplicate() {
RC_7eea8dd886abe2f5de3217d378b871fd t;
t.ssENIVAExceptionM9Suppliers = (EN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord)this.ssENIVAExceptionM9Suppliers.Duplicate();
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
if (head == "ivaexceptionm9suppliers") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IVAExceptionM9Suppliers")) variable.Value = ssENIVAExceptionM9Suppliers; else variable.Optimized = true;
variable.SetFieldName("ivaexceptionm9suppliers");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENIVAExceptionM9Suppliers.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENIVAExceptionM9Suppliers.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdIVAExceptionM9Suppliers) {
return ssENIVAExceptionM9Suppliers;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdIVAExceptionM9Suppliers.Key.AsGuid) {
return ssENIVAExceptionM9Suppliers;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENIVAExceptionM9Suppliers.FillFromOther((IRecord) other.AttributeGet(IdIVAExceptionM9Suppliers));
}
} // RC_7eea8dd886abe2f5de3217d378b871fd
/// <summary>
/// RecordList type <code>IVAExceptionM9SuppliersRecordList</code> that represents a record list of
///  <code>IVAExceptionM9Suppliers</code>
/// </summary>
public partial class RL_13bf94cd07d1032d5b0048443a2062e5 : GenericRecordList<RC_7eea8dd886abe2f5de3217d378b871fd>, IEnumerable, IEnumerator {

protected override RC_7eea8dd886abe2f5de3217d378b871fd GetElementDefaultValue() {
return new RC_7eea8dd886abe2f5de3217d378b871fd();
}

public T[] ToArray<T>(Func<RC_7eea8dd886abe2f5de3217d378b871fd, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_13bf94cd07d1032d5b0048443a2062e5 recordList, Func<RC_7eea8dd886abe2f5de3217d378b871fd, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_13bf94cd07d1032d5b0048443a2062e5(RC_7eea8dd886abe2f5de3217d378b871fd[] array) {
  RL_13bf94cd07d1032d5b0048443a2062e5 result = new RL_13bf94cd07d1032d5b0048443a2062e5();
result.InnerFromArray(array);
    return result;
}

public static RL_13bf94cd07d1032d5b0048443a2062e5 ToList<T>(T[] array, Func <T, RC_7eea8dd886abe2f5de3217d378b871fd> converter) {
  RL_13bf94cd07d1032d5b0048443a2062e5 result = new RL_13bf94cd07d1032d5b0048443a2062e5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_13bf94cd07d1032d5b0048443a2062e5 FromRestList<T>(RestList<T> restList, Func <T, RC_7eea8dd886abe2f5de3217d378b871fd> converter) {
  RL_13bf94cd07d1032d5b0048443a2062e5 result = new RL_13bf94cd07d1032d5b0048443a2062e5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_13bf94cd07d1032d5b0048443a2062e5() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(6,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_7eea8dd886abe2f5de3217d378b871fd> NewList() {
return new RL_13bf94cd07d1032d5b0048443a2062e5();
}


} // RL_13bf94cd07d1032d5b0048443a2062e5
}

