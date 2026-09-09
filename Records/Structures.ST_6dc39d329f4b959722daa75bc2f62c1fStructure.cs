namespace ssConectaProveedores {
/// <summary>
/// [Structure] FolioAccData (ez2seJD_JEax1jzQQEGBxQ)
///  <code>ST_6dc39d329f4b959722daa75bc2f62c1fStructure</code> that represents <code>FolioAccData</code
/// > <p>Description: </p>
/// </summary>
// Name: FolioAccData
public partial struct ST_6dc39d329f4b959722daa75bc2f62c1fStructure : ITypedRecord<ST_6dc39d329f4b959722daa75bc2f62c1fStructure> {
internal static readonly GlobalObjectKey IdOrderAccConceptID = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*vqaEu4lTp0OkEuJiHcYLfA");
internal static readonly GlobalObjectKey IdAmmount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Rmh+fLeWC0uesH9k37qLBQ");
internal static readonly GlobalObjectKey IdCurrencyID = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*uNnviqTwU0aft9io5LhMfQ");
internal static readonly GlobalObjectKey IdPaymentDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*33Obv9LfjUajnb_JHhmXEw");

public long ssOrderAccConceptID;

public decimal ssAmmount;

public string ssCurrencyID;

public DateTime ssPaymentDate;


public BitArray OptimizedAttributes;

public ST_6dc39d329f4b959722daa75bc2f62c1fStructure() {
OptimizedAttributes = null;
ssOrderAccConceptID = 0L;
ssAmmount = 0.0M;
ssCurrencyID = "";
ssPaymentDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssOrderAccConceptID = r.ReadEntityReferenceLongInteger(index++, "FolioAccData.OrderAccConceptID", 0L);
ssAmmount = r.ReadDecimal(index++, "FolioAccData.Ammount", 0.0M);
ssCurrencyID = r.ReadEntityReferenceText(index++, "FolioAccData.CurrencyID", "");
ssPaymentDate = r.ReadDate(index++, "FolioAccData.PaymentDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
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
public void ReadIM(ST_6dc39d329f4b959722daa75bc2f62c1fStructure r) {
this = r;
}


public static bool operator == (ST_6dc39d329f4b959722daa75bc2f62c1fStructure a, ST_6dc39d329f4b959722daa75bc2f62c1fStructure b) {
if (a.ssOrderAccConceptID != b.ssOrderAccConceptID) return false;
if (a.ssAmmount != b.ssAmmount) return false;
if (a.ssCurrencyID != b.ssCurrencyID) return false;
if (a.ssPaymentDate != b.ssPaymentDate) return false;
return true;
}

public static bool operator != (ST_6dc39d329f4b959722daa75bc2f62c1fStructure a, ST_6dc39d329f4b959722daa75bc2f62c1fStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_6dc39d329f4b959722daa75bc2f62c1fStructure)) return false;
return (this == (ST_6dc39d329f4b959722daa75bc2f62c1fStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssOrderAccConceptID.GetHashCode()
 ^ ssAmmount.GetHashCode()
 ^ ssCurrencyID.GetHashCode()
 ^ ssPaymentDate.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_6dc39d329f4b959722daa75bc2f62c1fStructure Duplicate() {
ST_6dc39d329f4b959722daa75bc2f62c1fStructure t;
t.ssOrderAccConceptID = this.ssOrderAccConceptID;
t.ssAmmount = this.ssAmmount;
t.ssCurrencyID = this.ssCurrencyID;
t.ssPaymentDate = this.ssPaymentDate;
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
if (head == "orderaccconceptid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderAccConceptID")) variable.Value = ssOrderAccConceptID; else variable.Optimized = true;
} else if (head == "ammount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Ammount")) variable.Value = ssAmmount; else variable.Optimized = true;
} else if (head == "currencyid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CurrencyID")) variable.Value = ssCurrencyID; else variable.Optimized = true;
} else if (head == "paymentdate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentDate")) variable.Value = ssPaymentDate; else variable.Optimized = true;
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
if (key == IdOrderAccConceptID) {
return ssOrderAccConceptID;
}
if (key == IdAmmount) {
return ssAmmount;
}
if (key == IdCurrencyID) {
return ssCurrencyID;
}
if (key == IdPaymentDate) {
return ssPaymentDate;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderAccConceptID.Key.AsGuid) {
return ssOrderAccConceptID;
}
if (attributeKey == IdAmmount.Key.AsGuid) {
return ssAmmount;
}
if (attributeKey == IdCurrencyID.Key.AsGuid) {
return ssCurrencyID;
}
if (attributeKey == IdPaymentDate.Key.AsGuid) {
return ssPaymentDate;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssOrderAccConceptID = (long) other.AttributeGet(IdOrderAccConceptID);
ssAmmount = (decimal) other.AttributeGet(IdAmmount);
ssCurrencyID = (string) other.AttributeGet(IdCurrencyID);
ssPaymentDate = (DateTime) other.AttributeGet(IdPaymentDate);
}
} // ST_6dc39d329f4b959722daa75bc2f62c1fStructure
/// <summary>
/// RecordList type <code>FolioAccDataList</code> that represents a record list of
///  <code>FolioAccData</code>
/// </summary>
public partial class RL_a829d5c83ca6a30b6720ad22b0566dda : GenericRecordList<ST_6dc39d329f4b959722daa75bc2f62c1fStructure>, IEnumerable, IEnumerator {

protected override ST_6dc39d329f4b959722daa75bc2f62c1fStructure GetElementDefaultValue() {
return new ST_6dc39d329f4b959722daa75bc2f62c1fStructure();
}

public T[] ToArray<T>(Func<ST_6dc39d329f4b959722daa75bc2f62c1fStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a829d5c83ca6a30b6720ad22b0566dda recordList, Func<ST_6dc39d329f4b959722daa75bc2f62c1fStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a829d5c83ca6a30b6720ad22b0566dda(ST_6dc39d329f4b959722daa75bc2f62c1fStructure[] array) {
  RL_a829d5c83ca6a30b6720ad22b0566dda result = new RL_a829d5c83ca6a30b6720ad22b0566dda();
result.InnerFromArray(array);
    return result;
}

public static RL_a829d5c83ca6a30b6720ad22b0566dda ToList<T>(T[] array, Func <T, ST_6dc39d329f4b959722daa75bc2f62c1fStructure> converter) {
  RL_a829d5c83ca6a30b6720ad22b0566dda result = new RL_a829d5c83ca6a30b6720ad22b0566dda();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a829d5c83ca6a30b6720ad22b0566dda FromRestList<T>(RestList<T> restList, Func <T, ST_6dc39d329f4b959722daa75bc2f62c1fStructure> converter) {
  RL_a829d5c83ca6a30b6720ad22b0566dda result = new RL_a829d5c83ca6a30b6720ad22b0566dda();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a829d5c83ca6a30b6720ad22b0566dda() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_6dc39d329f4b959722daa75bc2f62c1fStructure> NewList() {
return new RL_a829d5c83ca6a30b6720ad22b0566dda();
}


} // RL_a829d5c83ca6a30b6720ad22b0566dda
}

