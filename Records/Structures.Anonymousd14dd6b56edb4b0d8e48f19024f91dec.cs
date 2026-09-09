namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (tdZN0dtuDUuOSPGQJPkd7A)
///  <code>RC_68f99e3ed8896e3b241abe92cbb6c9b0</code> that represents <code>InvoiceTaxTypeRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: InvoiceTaxTypeRecord
public partial struct RC_68f99e3ed8896e3b241abe92cbb6c9b0 : ITypedRecord<RC_68f99e3ed8896e3b241abe92cbb6c9b0> {
internal static readonly GlobalObjectKey IdInvoiceTaxType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Pp75aInYO24kGr6Sy7bJsA");

public EN_cff5cb02ac5fe11578884acf37327af3EntityRecord ssENInvoiceTaxType;


public static implicit operator EN_cff5cb02ac5fe11578884acf37327af3EntityRecord( RC_68f99e3ed8896e3b241abe92cbb6c9b0 r) {
return r.ssENInvoiceTaxType;
}

public static implicit operator RC_68f99e3ed8896e3b241abe92cbb6c9b0 (EN_cff5cb02ac5fe11578884acf37327af3EntityRecord r) {
RC_68f99e3ed8896e3b241abe92cbb6c9b0 res = new RC_68f99e3ed8896e3b241abe92cbb6c9b0 ();
res.ssENInvoiceTaxType = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENInvoiceTaxType.ChangedAttributes = value;
}
get {
    return ssENInvoiceTaxType.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_68f99e3ed8896e3b241abe92cbb6c9b0() {
OptimizedAttributes = null;
ssENInvoiceTaxType = new EN_cff5cb02ac5fe11578884acf37327af3EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceTaxType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENInvoiceTaxType.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENInvoiceTaxType.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoiceTaxType.Read( r, ref index);
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
public void ReadIM(RC_68f99e3ed8896e3b241abe92cbb6c9b0 r) {
this = r;
}


public static bool operator == (RC_68f99e3ed8896e3b241abe92cbb6c9b0 a, RC_68f99e3ed8896e3b241abe92cbb6c9b0 b) {
if (a.ssENInvoiceTaxType != b.ssENInvoiceTaxType) return false;
return true;
}

public static bool operator != (RC_68f99e3ed8896e3b241abe92cbb6c9b0 a, RC_68f99e3ed8896e3b241abe92cbb6c9b0 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_68f99e3ed8896e3b241abe92cbb6c9b0)) return false;
return (this == (RC_68f99e3ed8896e3b241abe92cbb6c9b0)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceTaxType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceTaxType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceTaxType.InternalRecursiveSave();
}


public RC_68f99e3ed8896e3b241abe92cbb6c9b0 Duplicate() {
RC_68f99e3ed8896e3b241abe92cbb6c9b0 t;
t.ssENInvoiceTaxType = (EN_cff5cb02ac5fe11578884acf37327af3EntityRecord)this.ssENInvoiceTaxType.Duplicate();
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
if (head == "invoicetaxtype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceTaxType")) variable.Value = ssENInvoiceTaxType; else variable.Optimized = true;
variable.SetFieldName("invoicetaxtype");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceTaxType.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceTaxType.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoiceTaxType) {
return ssENInvoiceTaxType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceTaxType.Key.AsGuid) {
return ssENInvoiceTaxType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceTaxType.FillFromOther((IRecord) other.AttributeGet(IdInvoiceTaxType));
}
} // RC_68f99e3ed8896e3b241abe92cbb6c9b0
/// <summary>
/// RecordList type <code>InvoiceTaxTypeRecordList</code> that represents a record list of
///  <code>InvoiceTaxType</code>
/// </summary>
public partial class RL_fb38d880a635bb2e019a8913786fdded : GenericRecordList<RC_68f99e3ed8896e3b241abe92cbb6c9b0>, IEnumerable, IEnumerator {

protected override RC_68f99e3ed8896e3b241abe92cbb6c9b0 GetElementDefaultValue() {
return new RC_68f99e3ed8896e3b241abe92cbb6c9b0();
}

public T[] ToArray<T>(Func<RC_68f99e3ed8896e3b241abe92cbb6c9b0, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_fb38d880a635bb2e019a8913786fdded recordList, Func<RC_68f99e3ed8896e3b241abe92cbb6c9b0, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_fb38d880a635bb2e019a8913786fdded(RC_68f99e3ed8896e3b241abe92cbb6c9b0[] array) {
  RL_fb38d880a635bb2e019a8913786fdded result = new RL_fb38d880a635bb2e019a8913786fdded();
result.InnerFromArray(array);
    return result;
}

public static RL_fb38d880a635bb2e019a8913786fdded ToList<T>(T[] array, Func <T, RC_68f99e3ed8896e3b241abe92cbb6c9b0> converter) {
  RL_fb38d880a635bb2e019a8913786fdded result = new RL_fb38d880a635bb2e019a8913786fdded();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_fb38d880a635bb2e019a8913786fdded FromRestList<T>(RestList<T> restList, Func <T, RC_68f99e3ed8896e3b241abe92cbb6c9b0> converter) {
  RL_fb38d880a635bb2e019a8913786fdded result = new RL_fb38d880a635bb2e019a8913786fdded();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_fb38d880a635bb2e019a8913786fdded() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(4,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_68f99e3ed8896e3b241abe92cbb6c9b0> NewList() {
return new RL_fb38d880a635bb2e019a8913786fdded();
}


} // RL_fb38d880a635bb2e019a8913786fdded
}

