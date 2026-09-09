namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (6pqV7VoE10KzlDYi9DlCsA)
///  <code>RC_ede323d374bfaaf1250e4715618dd7eb</code> that represent
/// s
///  <code>CurrencyContractFileTypeOrderRequestFileOrderContractFileOrderMainOrderDetailOrderFileRecord<
/// /code> <p>Description: </p>
/// </summary>
// Name: CurrencyContractFileTypeOrderRequestFileOrderContractFileOrderMainOrderDetailOrderFileRecord
public partial struct RC_ede323d374bfaaf1250e4715618dd7eb : ITypedRecord<RC_ede323d374bfaaf1250e4715618dd7eb> {
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*L_BoBOY11sygkvMhxdiojg");
internal static readonly GlobalObjectKey IdContractFileType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+pNubdteqtLSno8Vs_ca6w");
internal static readonly GlobalObjectKey IdOrderRequestFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bBLYcy5yTSvWYtqyvxpy0Q");
internal static readonly GlobalObjectKey IdOrderContractFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Ls24vaMN4urxcJQolfKjrA");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdOrderDetail = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*__4Pf33sZAjriFX+joc3Qw");
internal static readonly GlobalObjectKey IdOrderFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NUo5p8E99rc2qs7SCeZhFg");

public EN_327b52812b8badb247bde4975c10d441EntityRecord ssENCurrency;

public EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord ssENContractFileType;

public EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord ssENOrderRequestFile;

public EN_17538b35348920159ed0ee43b3fb2b50EntityRecord ssENOrderContractFile;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_26f696e758428762fc617e811634d15dEntityRecord ssENOrderDetail;

public EN_096339be3ef098b3762e8897e3a1c095EntityRecord ssENOrderFile;


public BitArray OptimizedAttributes;

public RC_ede323d374bfaaf1250e4715618dd7eb() {
OptimizedAttributes = null;
ssENCurrency = new EN_327b52812b8badb247bde4975c10d441EntityRecord();
ssENContractFileType = new EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord();
ssENOrderRequestFile = new EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord();
ssENOrderContractFile = new EN_17538b35348920159ed0ee43b3fb2b50EntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENOrderDetail = new EN_26f696e758428762fc617e811634d15dEntityRecord();
ssENOrderFile = new EN_096339be3ef098b3762e8897e3a1c095EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[7];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(4,false);
    all[2] = new BitArray(17,false);
    all[3] = new BitArray(14,false);
    all[4] = new BitArray(29,false);
    all[5] = new BitArray(39,false);
    all[6] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCurrency.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENContractFileType.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENOrderRequestFile.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENOrderContractFile.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENOrderDetail.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENOrderFile.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    }else{
    ssENCurrency.OptimizedAttributes = value[0];
    ssENContractFileType.OptimizedAttributes = value[1];
    ssENOrderRequestFile.OptimizedAttributes = value[2];
    ssENOrderContractFile.OptimizedAttributes = value[3];
    ssENOrderMain.OptimizedAttributes = value[4];
    ssENOrderDetail.OptimizedAttributes = value[5];
    ssENOrderFile.OptimizedAttributes = value[6];
    }
}
get{
    BitArray[] all = new BitArray[7];
    all[0] = ssENCurrency.OptimizedAttributes;
    all[1] = ssENContractFileType.OptimizedAttributes;
    all[2] = ssENOrderRequestFile.OptimizedAttributes;
    all[3] = ssENOrderContractFile.OptimizedAttributes;
    all[4] = ssENOrderMain.OptimizedAttributes;
    all[5] = ssENOrderDetail.OptimizedAttributes;
    all[6] = ssENOrderFile.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENCurrency.Read( r, ref index);
ssENContractFileType.Read( r, ref index);
ssENOrderRequestFile.Read( r, ref index);
ssENOrderContractFile.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssENOrderDetail.Read( r, ref index);
ssENOrderFile.Read( r, ref index);
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
public void ReadIM(RC_ede323d374bfaaf1250e4715618dd7eb r) {
this = r;
}


public static bool operator == (RC_ede323d374bfaaf1250e4715618dd7eb a, RC_ede323d374bfaaf1250e4715618dd7eb b) {
if (a.ssENCurrency != b.ssENCurrency) return false;
if (a.ssENContractFileType != b.ssENContractFileType) return false;
if (a.ssENOrderRequestFile != b.ssENOrderRequestFile) return false;
if (a.ssENOrderContractFile != b.ssENOrderContractFile) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENOrderDetail != b.ssENOrderDetail) return false;
if (a.ssENOrderFile != b.ssENOrderFile) return false;
return true;
}

public static bool operator != (RC_ede323d374bfaaf1250e4715618dd7eb a, RC_ede323d374bfaaf1250e4715618dd7eb b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ede323d374bfaaf1250e4715618dd7eb)) return false;
return (this == (RC_ede323d374bfaaf1250e4715618dd7eb)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCurrency.GetHashCode()
 ^ ssENContractFileType.GetHashCode()
 ^ ssENOrderRequestFile.GetHashCode()
 ^ ssENOrderContractFile.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENOrderDetail.GetHashCode()
 ^ ssENOrderFile.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCurrency.RecursiveReset();
ssENContractFileType.RecursiveReset();
ssENOrderRequestFile.RecursiveReset();
ssENOrderContractFile.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENOrderDetail.RecursiveReset();
ssENOrderFile.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCurrency.InternalRecursiveSave();
ssENContractFileType.InternalRecursiveSave();
ssENOrderRequestFile.InternalRecursiveSave();
ssENOrderContractFile.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENOrderDetail.InternalRecursiveSave();
ssENOrderFile.InternalRecursiveSave();
}


public RC_ede323d374bfaaf1250e4715618dd7eb Duplicate() {
RC_ede323d374bfaaf1250e4715618dd7eb t;
t.ssENCurrency = (EN_327b52812b8badb247bde4975c10d441EntityRecord)this.ssENCurrency.Duplicate();
t.ssENContractFileType = (EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord)this.ssENContractFileType.Duplicate();
t.ssENOrderRequestFile = (EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord)this.ssENOrderRequestFile.Duplicate();
t.ssENOrderContractFile = (EN_17538b35348920159ed0ee43b3fb2b50EntityRecord)this.ssENOrderContractFile.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENOrderDetail = (EN_26f696e758428762fc617e811634d15dEntityRecord)this.ssENOrderDetail.Duplicate();
t.ssENOrderFile = (EN_096339be3ef098b3762e8897e3a1c095EntityRecord)this.ssENOrderFile.Duplicate();
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
if (head == "currency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Currency")) variable.Value = ssENCurrency; else variable.Optimized = true;
variable.SetFieldName("currency");
} else if (head == "contractfiletype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ContractFileType")) variable.Value = ssENContractFileType; else variable.Optimized = true;
variable.SetFieldName("contractfiletype");
} else if (head == "orderrequestfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderRequestFile")) variable.Value = ssENOrderRequestFile; else variable.Optimized = true;
variable.SetFieldName("orderrequestfile");
} else if (head == "ordercontractfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderContractFile")) variable.Value = ssENOrderContractFile; else variable.Optimized = true;
variable.SetFieldName("ordercontractfile");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "orderdetail") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderDetail")) variable.Value = ssENOrderDetail; else variable.Optimized = true;
variable.SetFieldName("orderdetail");
} else if (head == "orderfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderFile")) variable.Value = ssENOrderFile; else variable.Optimized = true;
variable.SetFieldName("orderfile");
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
if (key == IdCurrency) {
return ssENCurrency;
}
if (key == IdContractFileType) {
return ssENContractFileType;
}
if (key == IdOrderRequestFile) {
return ssENOrderRequestFile;
}
if (key == IdOrderContractFile) {
return ssENOrderContractFile;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdOrderDetail) {
return ssENOrderDetail;
}
if (key == IdOrderFile) {
return ssENOrderFile;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCurrency.Key.AsGuid) {
return ssENCurrency;
}
if (attributeKey == IdContractFileType.Key.AsGuid) {
return ssENContractFileType;
}
if (attributeKey == IdOrderRequestFile.Key.AsGuid) {
return ssENOrderRequestFile;
}
if (attributeKey == IdOrderContractFile.Key.AsGuid) {
return ssENOrderContractFile;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdOrderDetail.Key.AsGuid) {
return ssENOrderDetail;
}
if (attributeKey == IdOrderFile.Key.AsGuid) {
return ssENOrderFile;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCurrency.FillFromOther((IRecord) other.AttributeGet(IdCurrency));
ssENContractFileType.FillFromOther((IRecord) other.AttributeGet(IdContractFileType));
ssENOrderRequestFile.FillFromOther((IRecord) other.AttributeGet(IdOrderRequestFile));
ssENOrderContractFile.FillFromOther((IRecord) other.AttributeGet(IdOrderContractFile));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENOrderDetail.FillFromOther((IRecord) other.AttributeGet(IdOrderDetail));
ssENOrderFile.FillFromOther((IRecord) other.AttributeGet(IdOrderFile));
}
} // RC_ede323d374bfaaf1250e4715618dd7eb
/// <summary>
/// RecordList type
///  <code>CurrencyContractFileTypeOrderRequestFileOrderContractFileOrderMainOrderDetailOrderFileRecordL
/// ist</code> that represents a record list of <code>Currency, ContractFileType, OrderRequestFile,
///  OrderContractFile, OrderMain, OrderDetail, OrderFile</code>
/// </summary>
public partial class RL_aa7c4357ade22a558be456b32e011ece : GenericRecordList<RC_ede323d374bfaaf1250e4715618dd7eb>, IEnumerable, IEnumerator {

protected override RC_ede323d374bfaaf1250e4715618dd7eb GetElementDefaultValue() {
return new RC_ede323d374bfaaf1250e4715618dd7eb();
}

public T[] ToArray<T>(Func<RC_ede323d374bfaaf1250e4715618dd7eb, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_aa7c4357ade22a558be456b32e011ece recordList, Func<RC_ede323d374bfaaf1250e4715618dd7eb, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_aa7c4357ade22a558be456b32e011ece(RC_ede323d374bfaaf1250e4715618dd7eb[] array) {
  RL_aa7c4357ade22a558be456b32e011ece result = new RL_aa7c4357ade22a558be456b32e011ece();
result.InnerFromArray(array);
    return result;
}

public static RL_aa7c4357ade22a558be456b32e011ece ToList<T>(T[] array, Func <T, RC_ede323d374bfaaf1250e4715618dd7eb> converter) {
  RL_aa7c4357ade22a558be456b32e011ece result = new RL_aa7c4357ade22a558be456b32e011ece();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_aa7c4357ade22a558be456b32e011ece FromRestList<T>(RestList<T> restList, Func <T, RC_ede323d374bfaaf1250e4715618dd7eb> converter) {
  RL_aa7c4357ade22a558be456b32e011ece result = new RL_aa7c4357ade22a558be456b32e011ece();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_aa7c4357ade22a558be456b32e011ece() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[7];
def[0] = new BitArray(5,false);
def[1] = new BitArray(4,false);
def[2] = new BitArray(17,false);
def[3] = new BitArray(14,false);
def[4] = new BitArray(29,false);
def[5] = new BitArray(39,false);
def[6] = new BitArray(8,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_ede323d374bfaaf1250e4715618dd7eb> NewList() {
return new RL_aa7c4357ade22a558be456b32e011ece();
}


} // RL_aa7c4357ade22a558be456b32e011ece
}

