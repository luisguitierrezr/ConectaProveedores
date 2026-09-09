namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Id6XMlzZ6ESP_pd3XKK9qQ)
///  <code>RC_7ea2828a21285060cce33ce8e91b5455</code> that represent
/// s <code>InvoiceOrderMainRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceOrderMainRecord
public partial struct RC_7ea2828a21285060cce33ce8e91b5455 : ITypedRecord<RC_7ea2828a21285060cce33ce8e91b5455> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;


public BitArray OptimizedAttributes;

public RC_7ea2828a21285060cce33ce8e91b5455() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(29,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENOrderMain.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENOrderMain.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoice.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
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
public void ReadIM(RC_7ea2828a21285060cce33ce8e91b5455 r) {
this = r;
}


public static bool operator == (RC_7ea2828a21285060cce33ce8e91b5455 a, RC_7ea2828a21285060cce33ce8e91b5455 b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
return true;
}

public static bool operator != (RC_7ea2828a21285060cce33ce8e91b5455 a, RC_7ea2828a21285060cce33ce8e91b5455 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_7ea2828a21285060cce33ce8e91b5455)) return false;
return (this == (RC_7ea2828a21285060cce33ce8e91b5455)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENOrderMain.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
}


public RC_7ea2828a21285060cce33ce8e91b5455 Duplicate() {
RC_7ea2828a21285060cce33ce8e91b5455 t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
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
if (head == "invoice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Invoice")) variable.Value = ssENInvoice; else variable.Optimized = true;
variable.SetFieldName("invoice");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoice) {
return ssENInvoice;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
}
} // RC_7ea2828a21285060cce33ce8e91b5455
/// <summary>
/// RecordList type <code>InvoiceOrderMainRecordList</code> that represents a record list of
///  <code>Invoice, OrderMain</code>
/// </summary>
public partial class RL_94dfde238a1e776567d307c1f3f8a94e : GenericRecordList<RC_7ea2828a21285060cce33ce8e91b5455>, IEnumerable, IEnumerator {

protected override RC_7ea2828a21285060cce33ce8e91b5455 GetElementDefaultValue() {
return new RC_7ea2828a21285060cce33ce8e91b5455();
}

public T[] ToArray<T>(Func<RC_7ea2828a21285060cce33ce8e91b5455, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_94dfde238a1e776567d307c1f3f8a94e recordList, Func<RC_7ea2828a21285060cce33ce8e91b5455, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_94dfde238a1e776567d307c1f3f8a94e(RC_7ea2828a21285060cce33ce8e91b5455[] array) {
  RL_94dfde238a1e776567d307c1f3f8a94e result = new RL_94dfde238a1e776567d307c1f3f8a94e();
result.InnerFromArray(array);
    return result;
}

public static RL_94dfde238a1e776567d307c1f3f8a94e ToList<T>(T[] array, Func <T, RC_7ea2828a21285060cce33ce8e91b5455> converter) {
  RL_94dfde238a1e776567d307c1f3f8a94e result = new RL_94dfde238a1e776567d307c1f3f8a94e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_94dfde238a1e776567d307c1f3f8a94e FromRestList<T>(RestList<T> restList, Func <T, RC_7ea2828a21285060cce33ce8e91b5455> converter) {
  RL_94dfde238a1e776567d307c1f3f8a94e result = new RL_94dfde238a1e776567d307c1f3f8a94e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_94dfde238a1e776567d307c1f3f8a94e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(24,false);
def[1] = new BitArray(29,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_7ea2828a21285060cce33ce8e91b5455> NewList() {
return new RL_94dfde238a1e776567d307c1f3f8a94e();
}


} // RL_94dfde238a1e776567d307c1f3f8a94e
}

