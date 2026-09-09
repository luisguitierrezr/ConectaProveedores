namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (ZcvoGSTFyk6RCKxwPXj5xg)
///  <code>RC_f8f8f0b7fba136e61b433a9935152136</code> that represent
/// s <code>CurrencyOrderMainItemOrderMainRecord</code> <p>Description: </p>
/// </summary>
// Name: CurrencyOrderMainItemOrderMainRecord
public partial struct RC_f8f8f0b7fba136e61b433a9935152136 : ITypedRecord<RC_f8f8f0b7fba136e61b433a9935152136> {
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*L_BoBOY11sygkvMhxdiojg");
internal static readonly GlobalObjectKey IdOrderMainItem = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*fyDMxBeQTt4BP6vPHo6+rw");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");

public EN_327b52812b8badb247bde4975c10d441EntityRecord ssENCurrency;

public EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord ssENOrderMainItem;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;


public BitArray OptimizedAttributes;

public RC_f8f8f0b7fba136e61b433a9935152136() {
OptimizedAttributes = null;
ssENCurrency = new EN_327b52812b8badb247bde4975c10d441EntityRecord();
ssENOrderMainItem = new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(51,false);
    all[2] = new BitArray(29,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCurrency.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderMainItem.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENCurrency.OptimizedAttributes = value[0];
    ssENOrderMainItem.OptimizedAttributes = value[1];
    ssENOrderMain.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENCurrency.OptimizedAttributes;
    all[1] = ssENOrderMainItem.OptimizedAttributes;
    all[2] = ssENOrderMain.OptimizedAttributes;
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
ssENOrderMainItem.Read( r, ref index);
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
public void ReadIM(RC_f8f8f0b7fba136e61b433a9935152136 r) {
this = r;
}


public static bool operator == (RC_f8f8f0b7fba136e61b433a9935152136 a, RC_f8f8f0b7fba136e61b433a9935152136 b) {
if (a.ssENCurrency != b.ssENCurrency) return false;
if (a.ssENOrderMainItem != b.ssENOrderMainItem) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
return true;
}

public static bool operator != (RC_f8f8f0b7fba136e61b433a9935152136 a, RC_f8f8f0b7fba136e61b433a9935152136 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f8f8f0b7fba136e61b433a9935152136)) return false;
return (this == (RC_f8f8f0b7fba136e61b433a9935152136)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCurrency.GetHashCode()
 ^ ssENOrderMainItem.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCurrency.RecursiveReset();
ssENOrderMainItem.RecursiveReset();
ssENOrderMain.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCurrency.InternalRecursiveSave();
ssENOrderMainItem.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
}


public RC_f8f8f0b7fba136e61b433a9935152136 Duplicate() {
RC_f8f8f0b7fba136e61b433a9935152136 t;
t.ssENCurrency = (EN_327b52812b8badb247bde4975c10d441EntityRecord)this.ssENCurrency.Duplicate();
t.ssENOrderMainItem = (EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord)this.ssENOrderMainItem.Duplicate();
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
if (head == "currency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Currency")) variable.Value = ssENCurrency; else variable.Optimized = true;
variable.SetFieldName("currency");
} else if (head == "ordermainitem") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMainItem")) variable.Value = ssENOrderMainItem; else variable.Optimized = true;
variable.SetFieldName("ordermainitem");
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
if (key == IdCurrency) {
return ssENCurrency;
}
if (key == IdOrderMainItem) {
return ssENOrderMainItem;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCurrency.Key.AsGuid) {
return ssENCurrency;
}
if (attributeKey == IdOrderMainItem.Key.AsGuid) {
return ssENOrderMainItem;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCurrency.FillFromOther((IRecord) other.AttributeGet(IdCurrency));
ssENOrderMainItem.FillFromOther((IRecord) other.AttributeGet(IdOrderMainItem));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
}
} // RC_f8f8f0b7fba136e61b433a9935152136
/// <summary>
/// RecordList type <code>CurrencyOrderMainItemOrderMainRecordList</code> that represents a record list
///  of <code>Currency, OrderMainItem, OrderMain</code>
/// </summary>
public partial class RL_cbc3788d09399db0fa3c1bb25405f30f : GenericRecordList<RC_f8f8f0b7fba136e61b433a9935152136>, IEnumerable, IEnumerator {

protected override RC_f8f8f0b7fba136e61b433a9935152136 GetElementDefaultValue() {
return new RC_f8f8f0b7fba136e61b433a9935152136();
}

public T[] ToArray<T>(Func<RC_f8f8f0b7fba136e61b433a9935152136, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_cbc3788d09399db0fa3c1bb25405f30f recordList, Func<RC_f8f8f0b7fba136e61b433a9935152136, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_cbc3788d09399db0fa3c1bb25405f30f(RC_f8f8f0b7fba136e61b433a9935152136[] array) {
  RL_cbc3788d09399db0fa3c1bb25405f30f result = new RL_cbc3788d09399db0fa3c1bb25405f30f();
result.InnerFromArray(array);
    return result;
}

public static RL_cbc3788d09399db0fa3c1bb25405f30f ToList<T>(T[] array, Func <T, RC_f8f8f0b7fba136e61b433a9935152136> converter) {
  RL_cbc3788d09399db0fa3c1bb25405f30f result = new RL_cbc3788d09399db0fa3c1bb25405f30f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_cbc3788d09399db0fa3c1bb25405f30f FromRestList<T>(RestList<T> restList, Func <T, RC_f8f8f0b7fba136e61b433a9935152136> converter) {
  RL_cbc3788d09399db0fa3c1bb25405f30f result = new RL_cbc3788d09399db0fa3c1bb25405f30f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_cbc3788d09399db0fa3c1bb25405f30f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(5,false);
def[1] = new BitArray(51,false);
def[2] = new BitArray(29,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_f8f8f0b7fba136e61b433a9935152136> NewList() {
return new RL_cbc3788d09399db0fa3c1bb25405f30f();
}


} // RL_cbc3788d09399db0fa3c1bb25405f30f
}

