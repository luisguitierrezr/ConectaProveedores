namespace ssConectaProveedores {
/// <summary>
/// [Structure] EntryOrderRequestCancel (0Qh_OpavNkexFHf_MNR+Gw)
///  <code>ST_ed201ff180bb2dd4a51ad889e8debcfaStructure</code> that represent
/// s <code>EntryOrderRequestCancel</code> <p>Description: </p>
/// </summary>
// Name: EntryOrderRequestCancel
public partial struct ST_ed201ff180bb2dd4a51ad889e8debcfaStructure : ITypedRecord<ST_ed201ff180bb2dd4a51ad889e8debcfaStructure> {
internal static readonly GlobalObjectKey IdOrderNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*5KtsoyUSkE+T+BYd3F39iw");
internal static readonly GlobalObjectKey IdOrderPosition = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*VqRK7d67LECNgDZdOpyxwg");
internal static readonly GlobalObjectKey IdGroupFolio = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*C+uVjwxO0EG_TsR5nQ5n+w");
internal static readonly GlobalObjectKey IdSMDocMaterial = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*hIvwY_b1QESDX7ywS0qVBQ");
internal static readonly GlobalObjectKey IdSMDocYear = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*qQfc4tg1VUuwoUda3Cs96A");
internal static readonly GlobalObjectKey IdEMDocMaterial = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*CfpCsOaWqEq1JLHmmC3yRw");
internal static readonly GlobalObjectKey IdEMDocYear = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ujHTYnJ+5km2YpVdLGTexg");

public string ssOrderNumber;

public string ssOrderPosition;

public string ssGroupFolio;

public string ssSMDocMaterial;

public string ssSMDocYear;

public string ssEMDocMaterial;

public string ssEMDocYear;


public BitArray OptimizedAttributes;

public ST_ed201ff180bb2dd4a51ad889e8debcfaStructure() {
OptimizedAttributes = null;
ssOrderNumber = "";
ssOrderPosition = "";
ssGroupFolio = "";
ssSMDocMaterial = "";
ssSMDocYear = "";
ssEMDocMaterial = "";
ssEMDocYear = "";
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
ssOrderNumber = r.ReadText(index++, "EntryOrderRequestCancel.OrderNumber", "");
ssOrderPosition = r.ReadText(index++, "EntryOrderRequestCancel.OrderPosition", "");
ssGroupFolio = r.ReadText(index++, "EntryOrderRequestCancel.GroupFolio", "");
ssSMDocMaterial = r.ReadText(index++, "EntryOrderRequestCancel.SMDocMaterial", "");
ssSMDocYear = r.ReadText(index++, "EntryOrderRequestCancel.SMDocYear", "");
ssEMDocMaterial = r.ReadText(index++, "EntryOrderRequestCancel.EMDocMaterial", "");
ssEMDocYear = r.ReadText(index++, "EntryOrderRequestCancel.EMDocYear", "");
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
public void ReadIM(ST_ed201ff180bb2dd4a51ad889e8debcfaStructure r) {
this = r;
}


public static bool operator == (ST_ed201ff180bb2dd4a51ad889e8debcfaStructure a, ST_ed201ff180bb2dd4a51ad889e8debcfaStructure b) {
if (a.ssOrderNumber != b.ssOrderNumber) return false;
if (a.ssOrderPosition != b.ssOrderPosition) return false;
if (a.ssGroupFolio != b.ssGroupFolio) return false;
if (a.ssSMDocMaterial != b.ssSMDocMaterial) return false;
if (a.ssSMDocYear != b.ssSMDocYear) return false;
if (a.ssEMDocMaterial != b.ssEMDocMaterial) return false;
if (a.ssEMDocYear != b.ssEMDocYear) return false;
return true;
}

public static bool operator != (ST_ed201ff180bb2dd4a51ad889e8debcfaStructure a, ST_ed201ff180bb2dd4a51ad889e8debcfaStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_ed201ff180bb2dd4a51ad889e8debcfaStructure)) return false;
return (this == (ST_ed201ff180bb2dd4a51ad889e8debcfaStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssOrderNumber.GetHashCode()
 ^ ssOrderPosition.GetHashCode()
 ^ ssGroupFolio.GetHashCode()
 ^ ssSMDocMaterial.GetHashCode()
 ^ ssSMDocYear.GetHashCode()
 ^ ssEMDocMaterial.GetHashCode()
 ^ ssEMDocYear.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_ed201ff180bb2dd4a51ad889e8debcfaStructure Duplicate() {
ST_ed201ff180bb2dd4a51ad889e8debcfaStructure t;
t.ssOrderNumber = this.ssOrderNumber;
t.ssOrderPosition = this.ssOrderPosition;
t.ssGroupFolio = this.ssGroupFolio;
t.ssSMDocMaterial = this.ssSMDocMaterial;
t.ssSMDocYear = this.ssSMDocYear;
t.ssEMDocMaterial = this.ssEMDocMaterial;
t.ssEMDocYear = this.ssEMDocYear;
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
if (head == "ordernumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderNumber")) variable.Value = ssOrderNumber; else variable.Optimized = true;
} else if (head == "orderposition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderPosition")) variable.Value = ssOrderPosition; else variable.Optimized = true;
} else if (head == "groupfolio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".GroupFolio")) variable.Value = ssGroupFolio; else variable.Optimized = true;
} else if (head == "smdocmaterial") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SMDocMaterial")) variable.Value = ssSMDocMaterial; else variable.Optimized = true;
} else if (head == "smdocyear") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SMDocYear")) variable.Value = ssSMDocYear; else variable.Optimized = true;
} else if (head == "emdocmaterial") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EMDocMaterial")) variable.Value = ssEMDocMaterial; else variable.Optimized = true;
} else if (head == "emdocyear") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EMDocYear")) variable.Value = ssEMDocYear; else variable.Optimized = true;
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
if (key == IdOrderNumber) {
return ssOrderNumber;
}
if (key == IdOrderPosition) {
return ssOrderPosition;
}
if (key == IdGroupFolio) {
return ssGroupFolio;
}
if (key == IdSMDocMaterial) {
return ssSMDocMaterial;
}
if (key == IdSMDocYear) {
return ssSMDocYear;
}
if (key == IdEMDocMaterial) {
return ssEMDocMaterial;
}
if (key == IdEMDocYear) {
return ssEMDocYear;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderNumber.Key.AsGuid) {
return ssOrderNumber;
}
if (attributeKey == IdOrderPosition.Key.AsGuid) {
return ssOrderPosition;
}
if (attributeKey == IdGroupFolio.Key.AsGuid) {
return ssGroupFolio;
}
if (attributeKey == IdSMDocMaterial.Key.AsGuid) {
return ssSMDocMaterial;
}
if (attributeKey == IdSMDocYear.Key.AsGuid) {
return ssSMDocYear;
}
if (attributeKey == IdEMDocMaterial.Key.AsGuid) {
return ssEMDocMaterial;
}
if (attributeKey == IdEMDocYear.Key.AsGuid) {
return ssEMDocYear;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssOrderNumber = (string) other.AttributeGet(IdOrderNumber);
ssOrderPosition = (string) other.AttributeGet(IdOrderPosition);
ssGroupFolio = (string) other.AttributeGet(IdGroupFolio);
ssSMDocMaterial = (string) other.AttributeGet(IdSMDocMaterial);
ssSMDocYear = (string) other.AttributeGet(IdSMDocYear);
ssEMDocMaterial = (string) other.AttributeGet(IdEMDocMaterial);
ssEMDocYear = (string) other.AttributeGet(IdEMDocYear);
}
} // ST_ed201ff180bb2dd4a51ad889e8debcfaStructure
/// <summary>
/// RecordList type <code>EntryOrderRequestCancelList</code> that represents a record list of
///  <code>EntryOrderRequestCancel</code>
/// </summary>
public partial class RL_6a3e74485224ec3b7a5acadc90eaea4c : GenericRecordList<ST_ed201ff180bb2dd4a51ad889e8debcfaStructure>, IEnumerable, IEnumerator {

protected override ST_ed201ff180bb2dd4a51ad889e8debcfaStructure GetElementDefaultValue() {
return new ST_ed201ff180bb2dd4a51ad889e8debcfaStructure();
}

public T[] ToArray<T>(Func<ST_ed201ff180bb2dd4a51ad889e8debcfaStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6a3e74485224ec3b7a5acadc90eaea4c recordList, Func<ST_ed201ff180bb2dd4a51ad889e8debcfaStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6a3e74485224ec3b7a5acadc90eaea4c(ST_ed201ff180bb2dd4a51ad889e8debcfaStructure[] array) {
  RL_6a3e74485224ec3b7a5acadc90eaea4c result = new RL_6a3e74485224ec3b7a5acadc90eaea4c();
result.InnerFromArray(array);
    return result;
}

public static RL_6a3e74485224ec3b7a5acadc90eaea4c ToList<T>(T[] array, Func <T, ST_ed201ff180bb2dd4a51ad889e8debcfaStructure> converter) {
  RL_6a3e74485224ec3b7a5acadc90eaea4c result = new RL_6a3e74485224ec3b7a5acadc90eaea4c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6a3e74485224ec3b7a5acadc90eaea4c FromRestList<T>(RestList<T> restList, Func <T, ST_ed201ff180bb2dd4a51ad889e8debcfaStructure> converter) {
  RL_6a3e74485224ec3b7a5acadc90eaea4c result = new RL_6a3e74485224ec3b7a5acadc90eaea4c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6a3e74485224ec3b7a5acadc90eaea4c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_ed201ff180bb2dd4a51ad889e8debcfaStructure> NewList() {
return new RL_6a3e74485224ec3b7a5acadc90eaea4c();
}


} // RL_6a3e74485224ec3b7a5acadc90eaea4c
}

